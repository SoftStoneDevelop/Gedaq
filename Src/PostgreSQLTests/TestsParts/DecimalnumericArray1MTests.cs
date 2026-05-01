

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
0.0521103303426544m,
0.410353414000322m,
0.426058168441705m,
0.354918838850646m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 10,
    Value = 
new System.Decimal[4]
{
0.297907657417186m,
0.791655198285296m,
0.266385891788428m,
0.839119743297936m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 9,
    Value = 
new System.Decimal[4]
{
0.75511517586776m,
0.357357438823139m,
0.891351049973111m,
0.62526309538467m,
},
    NullableValue = 
new System.Decimal[3]
{
0.960354577636641m,
0.709147759203124m,
0.629708135454019m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.213914381564501m,
0.181507739360969m,
0.844471121183192m,
},
},
            new DecimalnumericArray1M
{
    Id = 11,
    Value = 
new System.Decimal[3]
{
0.55328888505002m,
0.409077188367545m,
0.234778404488073m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 20,
    Value = 
new System.Decimal[3]
{
0.320096888044883m,
0.542454122605815m,
0.282693476674607m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 14,
    Value = 
new System.Decimal[4]
{
0.960326084022644m,
0.879673705638024m,
0.125164610950029m,
0.276522463811022m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 25,
    Value = 
new System.Decimal[3]
{
0.4770505403258m,
0.846507681655223m,
0.287520674155227m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.779648165582091m,
0.984267659420132m,
0.925793807068663m,
},
},
            new DecimalnumericArray1M
{
    Id = 31,
    Value = 
new System.Decimal[4]
{
0.313925688314657m,
0.358198748555213m,
0.584547483930449m,
0.141385296001673m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 22,
    Value = 
new System.Decimal[4]
{
0.378623902994531m,
0.707682064045934m,
0.70556419742445m,
0.942389062891849m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 34,
    Value = 
new System.Decimal[3]
{
0.995452024323571m,
0.470916679624295m,
0.91470614600931m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 42,
    Value = 
new System.Decimal[4]
{
0.228545359360926m,
0.59226900980704m,
0.755156314894377m,
0.30323118639034m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.196815208410026m,
0.188315553938731m,
0.73930936106724m,
},
    NullableValue = 
new System.Decimal[3]
{
0.768782573111454m,
0.139280716899253m,
0.447847654025273m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 51,
    Value = 
new System.Decimal[4]
{
0.104270684151107m,
0.110713398240152m,
0.269475917486036m,
0.315394697416505m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 52,
    Value = 
new System.Decimal[4]
{
0.214045534441099m,
0.348797209862364m,
0.874454602896498m,
0.858050865433735m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 31,
    Value = 
new System.Decimal[4]
{
0.594238418090045m,
0.058614952544356m,
0.555114702133538m,
0.0528461778404934m,
},
    NullableValue = 
new System.Decimal[4]
{
0.130567769372553m,
0.883652811449654m,
0.642243125108728m,
0.792199543639369m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 53,
    Value = 
new System.Decimal[3]
{
0.297758405138493m,
0.753677478930284m,
0.812217594271716m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 59,
    Value = 
new System.Decimal[4]
{
0.655854408448339m,
0.604808793543856m,
0.380283550998701m,
0.639791586443297m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 33,
    Value = 
new System.Decimal[4]
{
0.0103599891603874m,
0.864935446915377m,
0.757452972938122m,
0.594187700381665m,
},
    NullableValue = 
new System.Decimal[3]
{
0.156719619478717m,
0.144546200783443m,
0.465814422024454m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.951502374139222m,
0.479138151639801m,
0.326327792608888m,
},
},
            new DecimalnumericArray1M
{
    Id = 62,
    Value = 
new System.Decimal[3]
{
0.979657092114959m,
0.115209299702985m,
0.398929014345571m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.825828701597867m,
0.330567092933402m,
0.94506689065989m,
},
},
            new DecimalnumericArray1M
{
    Id = 64,
    Value = 
new System.Decimal[3]
{
0.45282000095648m,
0.534169796076313m,
0.174547696085344m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 40,
    Value = 
new System.Decimal[3]
{
0.140434211011905m,
0.819863758318922m,
0.956875501396282m,
},
    NullableValue = 
new System.Decimal[3]
{
0.0358428280815041m,
0.894574205076483m,
0.744199010493058m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 69,
    Value = 
new System.Decimal[4]
{
0.38427259119446m,
0.664527553319303m,
0.80281349616651m,
0.463957253042456m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 75,
    Value = 
new System.Decimal[3]
{
0.383407400189188m,
0.942653275121458m,
0.771729023335502m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 47,
    Value = 
new System.Decimal[3]
{
0.249553707562429m,
0.137268912376168m,
0.329203957697416m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 77,
    Value = 
new System.Decimal[3]
{
0.289833181729278m,
0.551795790968026m,
0.918733617166756m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.847384122666834m,
0.927520870671231m,
0.130650350120309m,
0.698431098919149m,
},
},
            new DecimalnumericArray1M
{
    Id = 78,
    Value = 
new System.Decimal[4]
{
0.955360811523955m,
0.703437420640058m,
0.682144842982012m,
0.196730098131359m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 50,
    Value = 
new System.Decimal[4]
{
0.75428769675498m,
0.817204823053666m,
0.71798932434393m,
0.936941016145599m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 79,
    Value = 
new System.Decimal[3]
{
0.514510316511814m,
0.796870025586105m,
0.312583282932857m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.535408124161047m,
0.588716190577941m,
0.239765768581428m,
},
},
            new DecimalnumericArray1M
{
    Id = 88,
    Value = 
new System.Decimal[3]
{
0.285736956650752m,
0.62583001980667m,
0.158410492212568m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 58,
    Value = 
new System.Decimal[3]
{
0.170932734255612m,
0.391726160089729m,
0.667468577956388m,
},
    NullableValue = 
new System.Decimal[3]
{
0.926248789452201m,
0.65508546180243m,
0.735546709425716m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 90,
    Value = 
new System.Decimal[4]
{
0.916429182177688m,
0.132406341400416m,
0.978892598724041m,
0.929971548970692m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 95,
    Value = 
new System.Decimal[4]
{
0.539189634851321m,
0.431213520690804m,
0.563319152942607m,
0.124303108251115m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 67,
    Value = 
new System.Decimal[4]
{
0.744965770094194m,
0.686301260330457m,
0.193714575074069m,
0.546235690597326m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0314459784992558m,
0.0481954948049414m,
0.241736665553743m,
0.268330489635318m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.814336263679356m,
0.928209428505999m,
0.755413733844637m,
},
},
            new DecimalnumericArray1M
{
    Id = 104,
    Value = 
new System.Decimal[3]
{
0.232290270550742m,
0.115346197553928m,
0.502997288915107m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 106,
    Value = 
new System.Decimal[4]
{
0.125683615424561m,
0.390775129025085m,
0.157304200804869m,
0.941403601606693m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 72,
    Value = 
new System.Decimal[4]
{
0.372562013891526m,
0.0519095427422006m,
0.281651693130098m,
0.138834934211921m,
},
    NullableValue = 
new System.Decimal[3]
{
0.777099795328622m,
0.273602729197836m,
0.994400685981284m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 113,
    Value = 
new System.Decimal[3]
{
0.177798388940526m,
0.306144631600813m,
0.931089581655351m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 118,
    Value = 
new System.Decimal[3]
{
0.0738650400616378m,
0.21781696532029m,
0.283038722727481m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 75,
    Value = 
new System.Decimal[3]
{
0.973229419863746m,
0.341258778880766m,
0.473201881758031m,
},
    NullableValue = 
new System.Decimal[3]
{
0.21188755164105m,
0.973670370690737m,
0.230236348777345m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 123,
    Value = 
new System.Decimal[3]
{
0.193617192735472m,
0.167692032505926m,
0.425352609231423m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.376956534144274m,
0.796251258068417m,
0.340314583627484m,
},
},
            new DecimalnumericArray1M
{
    Id = 129,
    Value = 
new System.Decimal[3]
{
0.118090782243347m,
0.157245609315373m,
0.783213231408893m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 80,
    Value = 
new System.Decimal[3]
{
0.113256209973642m,
0.380405602139732m,
0.591146525327564m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 137,
    Value = 
new System.Decimal[3]
{
0.354775810428454m,
0.381296327607683m,
0.0766690498217771m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 146,
    Value = 
new System.Decimal[3]
{
0.50385494429616m,
0.152384955417837m,
0.652529166773847m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 84,
    Value = 
new System.Decimal[4]
{
0.301793190619727m,
0.531106104016652m,
0.293038684290613m,
0.642050309835442m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.211459690781305m,
0.345566709433332m,
0.170104786325644m,
0.593185250969124m,
},
},
            new DecimalnumericArray1M
{
    Id = 153,
    Value = 
new System.Decimal[4]
{
0.618094621658128m,
0.866187882625763m,
0.345871378658074m,
0.539916065414657m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.264575322726904m,
0.313374302175741m,
0.030820004574109m,
0.986270578343542m,
},
},
            new DecimalnumericArray1M
{
    Id = 158,
    Value = 
new System.Decimal[4]
{
0.399143409114352m,
0.901174741159712m,
0.658291610250057m,
0.836362244025348m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 85,
    Value = 
new System.Decimal[3]
{
0.545316142236634m,
0.750642180865053m,
0.711165122812663m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 164,
    Value = 
new System.Decimal[4]
{
0.355544798450145m,
0.469844105587492m,
0.420000256267284m,
0.738802576127769m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 166,
    Value = 
new System.Decimal[4]
{
0.777672315256213m,
0.58345482481059m,
0.582336105295633m,
0.328913667381272m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 94,
    Value = 
new System.Decimal[3]
{
0.924732285995659m,
0.517526777106072m,
0.211019796042117m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.164920680546865m,
0.242651210757581m,
0.0572169306504634m,
},
},
            new DecimalnumericArray1M
{
    Id = 170,
    Value = 
new System.Decimal[3]
{
0.472824993486577m,
0.950820783416162m,
0.955922768722634m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.157837456294918m,
0.403426399830569m,
0.580568564416557m,
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
new System.Decimal[3]
{
0.779648165582091m,
0.984267659420132m,
0.925793807068663m,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.951502374139222m,
0.479138151639801m,
0.326327792608888m,
}));
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 20, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[30],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 113, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 123, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 158, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 88, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 77, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 95, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
DecimalnumericArray1M.AssertModel(models[0],_testData[22], false);DecimalnumericArray1M.AssertModel(models[1],_testData[23], false);DecimalnumericArray1M.AssertModel(models[2],_testData[24], false);DecimalnumericArray1M.AssertModel(models[3],_testData[25], false);DecimalnumericArray1M.AssertModel(models[4],_testData[26], false);DecimalnumericArray1M.AssertModel(models[5],_testData[27], false);DecimalnumericArray1M.AssertModel(models[6],_testData[28], false);DecimalnumericArray1M.AssertModel(models[7],_testData[29], false);DecimalnumericArray1M.AssertModel(models[8],_testData[30], false);DecimalnumericArray1M.AssertModel(models[9],_testData[31], false);DecimalnumericArray1M.AssertModel(models[10],_testData[32], false);DecimalnumericArray1M.AssertModel(models[11],_testData[33], false);DecimalnumericArray1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));
DecimalnumericArray1M.AssertModel(models[0],_testData[3], false);DecimalnumericArray1M.AssertModel(models[1],_testData[4], false);DecimalnumericArray1M.AssertModel(models[2],_testData[5], false);DecimalnumericArray1M.AssertModel(models[3],_testData[6], false);DecimalnumericArray1M.AssertModel(models[4],_testData[7], false);DecimalnumericArray1M.AssertModel(models[5],_testData[8], false);DecimalnumericArray1M.AssertModel(models[6],_testData[9], false);DecimalnumericArray1M.AssertModel(models[7],_testData[10], false);DecimalnumericArray1M.AssertModel(models[8],_testData[11], false);DecimalnumericArray1M.AssertModel(models[9],_testData[12], false);DecimalnumericArray1M.AssertModel(models[10],_testData[13], false);DecimalnumericArray1M.AssertModel(models[11],_testData[14], false);DecimalnumericArray1M.AssertModel(models[12],_testData[15], false);DecimalnumericArray1M.AssertModel(models[13],_testData[16], false);DecimalnumericArray1M.AssertModel(models[14],_testData[17], false);DecimalnumericArray1M.AssertModel(models[15],_testData[18], false);DecimalnumericArray1M.AssertModel(models[16],_testData[19], false);DecimalnumericArray1M.AssertModel(models[17],_testData[20], false);DecimalnumericArray1M.AssertModel(models[18],_testData[21], false);DecimalnumericArray1M.AssertModel(models[19],_testData[22], false);DecimalnumericArray1M.AssertModel(models[20],_testData[23], false);DecimalnumericArray1M.AssertModel(models[21],_testData[24], false);DecimalnumericArray1M.AssertModel(models[22],_testData[25], false);DecimalnumericArray1M.AssertModel(models[23],_testData[26], false);DecimalnumericArray1M.AssertModel(models[24],_testData[27], false);DecimalnumericArray1M.AssertModel(models[25],_testData[28], false);DecimalnumericArray1M.AssertModel(models[26],_testData[29], false);DecimalnumericArray1M.AssertModel(models[27],_testData[30], false);DecimalnumericArray1M.AssertModel(models[28],_testData[31], false);DecimalnumericArray1M.AssertModel(models[29],_testData[32], false);DecimalnumericArray1M.AssertModel(models[30],_testData[33], false);DecimalnumericArray1M.AssertModel(models[31],_testData[34], false);
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

