

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
    internal partial interface IDoubleArraydouble_precisionArray
    {
    }
    
    internal partial class DoubleArraydouble_precisionArray : IDoubleArraydouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray1M[] _testData = new Doubledouble_precisionArray1M[]
        {
            new Doubledouble_precisionArray1M
{
    Id = 5,
    Value = 
new System.Double[4]
{
0.9448532382130983d,
0.7478974078858438d,
0.6001095163814665d,
0.35763672866103546d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.4949734999481691d,
0.047342083275404456d,
0.5259190881460771d,
0.8957358322473132d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 8,
    Value = 
new System.Double[4]
{
0.573454910267826d,
0.8837024612520263d,
0.380303692164243d,
0.42133349435007617d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 3,
    Value = 
new System.Double[4]
{
0.9233144101237634d,
0.6490270396855045d,
0.21561963426031627d,
0.2970795864208282d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 16,
    Value = 
new System.Double[3]
{
0.8777659564655204d,
0.8094393748658476d,
0.5844943333143569d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.26547264200484877d,
0.9023134671230737d,
0.15077107958936864d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 21,
    Value = 
new System.Double[3]
{
0.06394687672411958d,
0.024833096748679284d,
0.01795314059486941d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 6,
    Value = 
new System.Double[3]
{
0.01675750282791688d,
0.10353359457237854d,
0.6057640440495147d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.2512520467082954d,
0.44787209757875845d,
0.72609529075094d,
0.6752715652616993d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 22,
    Value = 
new System.Double[3]
{
0.5700390064579401d,
0.32967689993887095d,
0.8541659474634201d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3751143335773164d,
0.584946746409761d,
0.6759629794440059d,
0.26079727017645893d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 29,
    Value = 
new System.Double[3]
{
0.6783088438459344d,
0.263282701149141d,
0.7386703327305049d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 15,
    Value = 
new System.Double[3]
{
0.9244952027600327d,
0.27366099018546164d,
0.1776015218945617d,
},
    NullableValue = 
new System.Double[4]
{
0.484737573971446d,
0.9474827594615568d,
0.8242345184611733d,
0.6164490652911554d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 34,
    Value = 
new System.Double[4]
{
0.13374491383478082d,
0.7072358219795772d,
0.22138337038723255d,
0.8453920317283897d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.026779750857223283d,
0.03673816376851047d,
0.16710261193856568d,
0.9081330507402808d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 40,
    Value = 
new System.Double[3]
{
0.9149981642549788d,
0.5808082564420851d,
0.9091410721059562d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 24,
    Value = 
new System.Double[3]
{
0.0658247116582027d,
0.934427525518134d,
0.4051542527494778d,
},
    NullableValue = 
new System.Double[3]
{
0.12940562999718863d,
0.22886128735287448d,
0.46448816406132754d,
},
},
    NullableValue = 
new System.Double[3]
{
0.33822368169882633d,
0.8031542479753255d,
0.9923959726757299d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 49,
    Value = 
new System.Double[3]
{
0.46500873093137596d,
0.923335888786699d,
0.8701604695732092d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 51,
    Value = 
new System.Double[3]
{
0.290471522199086d,
0.18171379906489393d,
0.0029791889319548126d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 28,
    Value = 
new System.Double[3]
{
0.9650360172607481d,
0.9512685877943493d,
0.5708518396752181d,
},
    NullableValue = 
new System.Double[3]
{
0.4135729153001695d,
0.47426070908456963d,
0.5018957968508464d,
},
},
    NullableValue = 
new System.Double[3]
{
0.055530834873012136d,
0.36343511349496394d,
0.6481934207295518d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 56,
    Value = 
new System.Double[4]
{
0.6357867461243667d,
0.22503106413547358d,
0.5713214953168729d,
0.8785429275676224d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 58,
    Value = 
new System.Double[4]
{
0.30908039512979246d,
0.051756853197634456d,
0.9470920627838764d,
0.8803927954517565d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 37,
    Value = 
new System.Double[3]
{
0.1438662061553896d,
0.9006300160892393d,
0.6261088023483078d,
},
    NullableValue = 
new System.Double[3]
{
0.3491783569986253d,
0.008392560638080249d,
0.9399354653852946d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 65,
    Value = 
new System.Double[4]
{
0.2513197693542858d,
0.11490248871891728d,
0.6547956457136226d,
0.6009125663097229d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.9208638616945798d,
0.6263829163342769d,
0.2225211848863743d,
0.4362766207691273d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 66,
    Value = 
new System.Double[4]
{
0.8194661191521438d,
0.54268838566036d,
0.2693938453962075d,
0.35810961180312817d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 39,
    Value = 
new System.Double[3]
{
0.8067865610667894d,
0.6608784644985979d,
0.1605133712588389d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 73,
    Value = 
new System.Double[3]
{
0.9438759979589634d,
0.9559946797412253d,
0.4448269672467646d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.5569586685720498d,
0.27503077763179684d,
0.8327949167541651d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 78,
    Value = 
new System.Double[3]
{
0.16332022708351712d,
0.8021379784880134d,
0.19181461835048152d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 44,
    Value = 
new System.Double[3]
{
0.2089413742646149d,
0.110983401819853d,
0.8455900622485989d,
},
    NullableValue = 
new System.Double[3]
{
0.8878995501103755d,
0.8388540858032892d,
0.13658330814095576d,
},
},
    NullableValue = 
new System.Double[3]
{
0.9361012639466125d,
0.011681661473492255d,
0.4767028617037363d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 86,
    Value = 
new System.Double[3]
{
0.03349932430184577d,
0.9408486504297406d,
0.08433615374541026d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 88,
    Value = 
new System.Double[4]
{
0.3764238080082436d,
0.577844336166386d,
0.3319536800872097d,
0.06645361647811088d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 53,
    Value = 
new System.Double[4]
{
0.3898170400952734d,
0.8171365939995707d,
0.29505604775464944d,
0.25869031187645564d,
},
    NullableValue = 
new System.Double[3]
{
0.7444062826632518d,
0.25605160998199705d,
0.7957259078268817d,
},
},
    NullableValue = 
new System.Double[4]
{
0.5617356575221956d,
0.6664820398863929d,
0.7978905143825954d,
0.5921421564437651d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 92,
    Value = 
new System.Double[4]
{
0.6682430015590056d,
0.6817108038732735d,
0.7383938622931505d,
0.7445473200919649d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 101,
    Value = 
new System.Double[4]
{
0.01688848296358647d,
0.514640392978399d,
0.9357609070002261d,
0.8393661844644364d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 58,
    Value = 
new System.Double[4]
{
0.8853292615485874d,
0.5187511084812036d,
0.19533111590270635d,
0.29443445465660856d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 107,
    Value = 
new System.Double[4]
{
0.7536485408325216d,
0.9092600764454939d,
0.3018006283468154d,
0.9378552080122617d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.18215377860594617d,
0.35690006931553553d,
0.2728788322306335d,
0.7096637620226598d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 108,
    Value = 
new System.Double[3]
{
0.4084734049343359d,
0.47859859216102363d,
0.9734951589558739d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 62,
    Value = 
new System.Double[4]
{
0.9879571260085378d,
0.7903867187015807d,
0.6421767944714873d,
0.8668096796700718d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.28743018030761136d,
0.7362750542493058d,
0.45998100581174195d,
0.7231251760051999d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 117,
    Value = 
new System.Double[3]
{
0.1961658411834074d,
0.1135196682696662d,
0.816684091367537d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.053528914938493655d,
0.08367472052737446d,
0.9166092302606481d,
0.9297996665336369d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 121,
    Value = 
new System.Double[4]
{
0.6900781837854061d,
0.3468687200092119d,
0.9455602734647156d,
0.9347600709105894d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 71,
    Value = 
new System.Double[4]
{
0.13829064567308313d,
0.6138613884721128d,
0.24023440317787115d,
0.42183234849328033d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 122,
    Value = 
new System.Double[3]
{
0.13462027304180824d,
0.5874801351793171d,
0.7812141456798128d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 127,
    Value = 
new System.Double[4]
{
0.32693788418627234d,
0.30400527427741153d,
0.5602165017326045d,
0.8202741939780384d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.31305678972976203d,
0.526012259946713d,
0.5954969039099902d,
0.6860702845115181d,
},
    NullableValue = 
new System.Double[3]
{
0.0077990272821676365d,
0.6036397868535216d,
0.23963093861245532d,
},
},
    NullableValue = 
new System.Double[3]
{
0.7730457993397497d,
0.14386841550312468d,
0.3945554457571071d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 131,
    Value = 
new System.Double[4]
{
0.4136572930075907d,
0.3230866562529643d,
0.20882913751845555d,
0.885710260372951d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 136,
    Value = 
new System.Double[4]
{
0.7924344022261562d,
0.3427373595665746d,
0.8940093184607989d,
0.6938856037078323d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 84,
    Value = 
new System.Double[3]
{
0.9786928260966713d,
0.8793852214456352d,
0.7910692080822641d,
},
    NullableValue = 
new System.Double[3]
{
0.11914416813750317d,
0.5853323988567259d,
0.9709764450338205d,
},
},
    NullableValue = 
new System.Double[3]
{
0.46530870637753796d,
0.24451958620049796d,
0.6651437941808026d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 145,
    Value = 
new System.Double[3]
{
0.9894369230782983d,
0.17924955985910018d,
0.4383041997899396d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 153,
    Value = 
new System.Double[4]
{
0.820466680851342d,
0.17000796804867568d,
0.8598748300704309d,
0.8196354713739058d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 93,
    Value = 
new System.Double[3]
{
0.47608479743018295d,
0.6092903627170012d,
0.291579764984629d,
},
    NullableValue = 
new System.Double[4]
{
0.7029131946464133d,
0.09835523669410351d,
0.3898342440988648d,
0.6447060450465133d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8157714808075528d,
0.13189785799177378d,
0.8498988933716766d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 162,
    Value = 
new System.Double[4]
{
0.16008632289459868d,
0.5966591550320893d,
0.04517220288333845d,
0.6566250824671821d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 169,
    Value = 
new System.Double[4]
{
0.34114341941786663d,
0.22613569332250383d,
0.9469505162029056d,
0.5629021296547657d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 96,
    Value = 
new System.Double[3]
{
0.7533786643125536d,
0.0851286361344129d,
0.3605536038682524d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.5600357583459322d,
0.285638169540144d,
0.8753178887780882d,
0.18390193741199323d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 170,
    Value = 
new System.Double[3]
{
0.4267186213951121d,
0.24139037374591354d,
0.5070063883716793d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8259000621791561d,
0.5422078496132261d,
0.9805974241204017d,
0.9598839341587306d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 175,
    Value = 
new System.Double[4]
{
0.41731627815888916d,
0.2393246495620036d,
0.6357406187710091d,
0.35237706517872724d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 99,
    Value = 
new System.Double[3]
{
0.31274076799805706d,
0.4472298855512181d,
0.1449665094742354d,
},
    NullableValue = 
new System.Double[4]
{
0.3576168071877672d,
0.326256076783246d,
0.6925277051679173d,
0.2740133532630449d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 179,
    Value = 
new System.Double[4]
{
0.2737530836327505d,
0.07608952335634356d,
0.9714557681248233d,
0.08257085598855529d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.07267229758144533d,
0.8435832773650811d,
0.6456747571037802d,
0.24418760858651056d,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
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

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.3751143335773164d,
0.584946746409761d,
0.6759629794440059d,
0.26079727017645893d,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.026779750857223283d,
0.03673816376851047d,
0.16710261193856568d,
0.9081330507402808d,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.33822368169882633d,
0.8031542479753255d,
0.9923959726757299d,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                System.Double[] nullable = null;
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.055530834873012136d,
0.36343511349496394d,
0.6481934207295518d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 78;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 170;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 16;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 127, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 92, query1, 169, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 122, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 66, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 56, query1, 58, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[3], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[4], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[29],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[30],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 78, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[14], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[15], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[19],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[20],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[21],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[22],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[23],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[24],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[25],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[26],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[27],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[28],_testData[29], false);
                Doubledouble_precisionArray1M.AssertModel(models[29],_testData[30], false);
                Doubledouble_precisionArray1M.AssertModel(models[30],_testData[31], false);
                Doubledouble_precisionArray1M.AssertModel(models[31],_testData[32], false);
                Doubledouble_precisionArray1M.AssertModel(models[32],_testData[33], false);
                Doubledouble_precisionArray1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[14], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[15], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[19],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[20],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[21],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[22],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[23],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[24],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[25],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[26],_testData[29], false);
                Doubledouble_precisionArray1M.AssertModel(models[27],_testData[30], false);
                Doubledouble_precisionArray1M.AssertModel(models[28],_testData[31], false);
                Doubledouble_precisionArray1M.AssertModel(models[29],_testData[32], false);
                Doubledouble_precisionArray1M.AssertModel(models[30],_testData[33], false);
                Doubledouble_precisionArray1M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray1m m
LEFT JOIN public.binary_doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI), typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                await ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleArraydouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

