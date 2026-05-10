

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
    Id = 6,
    Value = 
new System.Decimal[3]
{
0.265188155297206m,
0.68998920089071m,
0.745680704492408m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.75208806097601m,
0.947246918536599m,
0.11651623060072m,
},
},
            new DecimalnumericArray1M
{
    Id = 13,
    Value = 
new System.Decimal[4]
{
0.0446314789233194m,
0.488743134706952m,
0.385978320079534m,
0.769194777973684m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 3,
    Value = 
new System.Decimal[4]
{
0.410700189576945m,
0.586450112056017m,
0.716591576463742m,
0.1819448988268m,
},
    NullableValue = 
new System.Decimal[4]
{
0.194392941918836m,
0.533258530227764m,
0.670572061239224m,
0.338296617542222m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 16,
    Value = 
new System.Decimal[4]
{
0.502314973934985m,
0.0436506237754849m,
0.379026532729372m,
0.290813208547141m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.610868052006045m,
0.408160763002801m,
0.637417628011851m,
},
},
            new DecimalnumericArray1M
{
    Id = 25,
    Value = 
new System.Decimal[3]
{
0.294239689565778m,
0.728681790377092m,
0.51466965480936m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 11,
    Value = 
new System.Decimal[3]
{
0.374297212617381m,
0.67196114497965m,
0.803438147308536m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 29,
    Value = 
new System.Decimal[3]
{
0.769848740678066m,
0.428323265941307m,
0.471839665838062m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.20277717009716m,
0.722322040708437m,
0.0305133873820911m,
},
},
            new DecimalnumericArray1M
{
    Id = 31,
    Value = 
new System.Decimal[4]
{
0.128205852921097m,
0.824400356985414m,
0.0549079876486235m,
0.236997623890438m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 17,
    Value = 
new System.Decimal[4]
{
0.455339110141063m,
0.272345615224384m,
0.988638766367282m,
0.74321540065322m,
},
    NullableValue = 
new System.Decimal[3]
{
0.270343114212348m,
0.597939153373237m,
0.256992095866681m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 32,
    Value = 
new System.Decimal[4]
{
0.211166782985632m,
0.655038538881292m,
0.200576570257112m,
0.220732417812644m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 38,
    Value = 
new System.Decimal[3]
{
0.949785886503083m,
0.837831450555963m,
0.41667686507594m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 21,
    Value = 
new System.Decimal[4]
{
0.806508514430877m,
0.0300272577104626m,
0.280589165228476m,
0.451671858321444m,
},
    NullableValue = 
new System.Decimal[3]
{
0.479778634772613m,
0.617927980323221m,
0.756765390464062m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.257100644811476m,
0.298092888263696m,
0.127634654393676m,
},
},
            new DecimalnumericArray1M
{
    Id = 44,
    Value = 
new System.Decimal[3]
{
0.669496507110953m,
0.689356427259546m,
0.552288364412606m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 53,
    Value = 
new System.Decimal[4]
{
0.401365636751887m,
0.676420660379056m,
0.934848216478732m,
0.546695828301757m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 22,
    Value = 
new System.Decimal[4]
{
0.310763381328414m,
0.117818504002405m,
0.310185345605431m,
0.772195284468212m,
},
    NullableValue = 
new System.Decimal[4]
{
0.870343525362224m,
0.228917438259604m,
0.594459256091976m,
0.488813915484356m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 60,
    Value = 
new System.Decimal[4]
{
0.312751654245699m,
0.0624741719010783m,
0.454762815411563m,
0.42578244173083m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 67,
    Value = 
new System.Decimal[3]
{
0.52727561087911m,
0.620481660310494m,
0.636710674304546m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.107833513970409m,
0.0760302605617122m,
0.798350490281091m,
0.369214411070679m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 75,
    Value = 
new System.Decimal[4]
{
0.824562719877901m,
0.274126981268575m,
0.165007122590931m,
0.0408270302769501m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 81,
    Value = 
new System.Decimal[4]
{
0.878538878881627m,
0.915348857633661m,
0.0142093796856951m,
0.685143370939121m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 28,
    Value = 
new System.Decimal[3]
{
0.857379834700124m,
0.783694566157627m,
0.505092868743563m,
},
    NullableValue = 
new System.Decimal[3]
{
0.863164481878122m,
0.653197465559504m,
0.776146936070653m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 84,
    Value = 
new System.Decimal[3]
{
0.443920406888929m,
0.0763328611252283m,
0.703702688357069m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 88,
    Value = 
new System.Decimal[3]
{
0.568918954652558m,
0.55389111938001m,
0.638871337947702m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 30,
    Value = 
new System.Decimal[3]
{
0.279933191032415m,
0.920114816230617m,
0.70231204783609m,
},
    NullableValue = 
new System.Decimal[4]
{
0.130963659291885m,
0.603095937438078m,
0.401921795406947m,
0.869987051195668m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 90,
    Value = 
new System.Decimal[3]
{
0.519317280882127m,
0.443418594945326m,
0.584044846902102m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.878349317093103m,
0.608269746458849m,
0.52416245422403m,
},
},
            new DecimalnumericArray1M
{
    Id = 91,
    Value = 
new System.Decimal[3]
{
0.816854007748166m,
0.334566429458762m,
0.272928206589134m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 35,
    Value = 
new System.Decimal[3]
{
0.154736339776592m,
0.102749569033954m,
0.628314659526392m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 93,
    Value = 
new System.Decimal[3]
{
0.312586793097875m,
0.0483086377556777m,
0.560044279634682m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.525302138624952m,
0.800889268338874m,
0.8445299363318m,
},
},
            new DecimalnumericArray1M
{
    Id = 100,
    Value = 
new System.Decimal[4]
{
0.783043789293182m,
0.977211044502347m,
0.587683739122039m,
0.206085225783165m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 44,
    Value = 
new System.Decimal[3]
{
0.0444377887610882m,
0.778316907592277m,
0.328002695016639m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.972089280183146m,
0.194171462178119m,
0.954110021552189m,
0.121789685650166m,
},
},
            new DecimalnumericArray1M
{
    Id = 103,
    Value = 
new System.Decimal[4]
{
0.4243754590095m,
0.0891090163376749m,
0.383260089525954m,
0.618511967377513m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.32100867459383m,
0.429938087055499m,
0.290245658211983m,
0.680075576622111m,
},
},
            new DecimalnumericArray1M
{
    Id = 105,
    Value = 
new System.Decimal[4]
{
0.784084610435982m,
0.782360479064676m,
0.198527564995171m,
0.899678587376811m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 45,
    Value = 
new System.Decimal[3]
{
0.763547018460156m,
0.609949087027182m,
0.240091657446002m,
},
    NullableValue = 
new System.Decimal[3]
{
0.898286075708256m,
0.205299873299473m,
0.578498682797793m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.70111232264936m,
0.526735608387935m,
0.0498612532737704m,
},
},
            new DecimalnumericArray1M
{
    Id = 114,
    Value = 
new System.Decimal[4]
{
0.44175887620998m,
0.106163741485878m,
0.220827517945346m,
0.349840320463044m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 121,
    Value = 
new System.Decimal[3]
{
0.316823173758342m,
0.962400262861006m,
0.789828840070281m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 54,
    Value = 
new System.Decimal[3]
{
0.204340520180961m,
0.998003736431655m,
0.460830285452633m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 124,
    Value = 
new System.Decimal[3]
{
0.224990901203992m,
0.578197611802915m,
0.505997664929815m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 127,
    Value = 
new System.Decimal[4]
{
0.143755672073068m,
0.565500644548863m,
0.937611804628718m,
0.638026155185656m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 59,
    Value = 
new System.Decimal[3]
{
0.855429230835486m,
0.292682166444363m,
0.376237892753861m,
},
    NullableValue = 
new System.Decimal[4]
{
0.966899446455331m,
0.668556527873682m,
0.233372866001742m,
0.595670279734914m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.141553086502086m,
0.063442600477409m,
0.905412245247391m,
},
},
            new DecimalnumericArray1M
{
    Id = 130,
    Value = 
new System.Decimal[3]
{
0.463016452251448m,
0.105808787961532m,
0.582491534785835m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 134,
    Value = 
new System.Decimal[4]
{
0.982239131527314m,
0.19743384411233m,
0.493787954163323m,
0.0711503712239468m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 63,
    Value = 
new System.Decimal[4]
{
0.386628082983284m,
0.317162923668546m,
0.499321255492114m,
0.666644971751499m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.584634607145303m,
0.937684753367822m,
0.918693726488818m,
0.427795016361669m,
},
},
            new DecimalnumericArray1M
{
    Id = 142,
    Value = 
new System.Decimal[3]
{
0.520348263779559m,
0.445837146577344m,
0.271689881724539m,
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
0.992283922728155m,
0.194501031386768m,
0.477572522298941m,
0.86610081931848m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 69,
    Value = 
new System.Decimal[4]
{
0.107524471362532m,
0.169636229639602m,
0.604153933050542m,
0.53356115545737m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.0291024963212182m,
0.841777861639518m,
0.301736850818066m,
},
},
            new DecimalnumericArray1M
{
    Id = 156,
    Value = 
new System.Decimal[4]
{
0.790424708034608m,
0.19050157263741m,
0.703008062006382m,
0.482457154559509m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.630488859520929m,
0.895215992456518m,
0.418288538152141m,
0.829835499657238m,
},
},
            new DecimalnumericArray1M
{
    Id = 157,
    Value = 
new System.Decimal[4]
{
0.785308310511297m,
0.351931250192884m,
0.228925224410156m,
0.387430973234663m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 70,
    Value = 
new System.Decimal[4]
{
0.619520000733534m,
0.13972441846784m,
0.659811561488066m,
0.9714716502247m,
},
    NullableValue = 
new System.Decimal[3]
{
0.233766862029983m,
0.993437325011657m,
0.236304567493233m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.53638464172746m,
0.081850427866565m,
0.0224877222066737m,
},
},
            new DecimalnumericArray1M
{
    Id = 161,
    Value = 
new System.Decimal[3]
{
0.646302430693903m,
0.653048568710753m,
0.930304206002794m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0444638708622604m,
0.257027382369175m,
0.267724580735765m,
},
},
            new DecimalnumericArray1M
{
    Id = 170,
    Value = 
new System.Decimal[3]
{
0.879739652204315m,
0.243737060609193m,
0.387931501413654m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 77,
    Value = 
new System.Decimal[4]
{
0.910716188484332m,
0.641916031573989m,
0.888426773995258m,
0.323887169303479m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 177,
    Value = 
new System.Decimal[3]
{
0.252215169860547m,
0.03925294244716m,
0.832318957378506m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.586700970594406m,
0.722162127373613m,
0.244836635444935m,
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
0.20277717009716m,
0.722322040708437m,
0.0305133873820911m,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.257100644811476m,
0.298092888263696m,
0.127634654393676m,
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 147;
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 127, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 127, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 88, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 134, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 134, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 16, query1, 53, query2))
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 100, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 157, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[28],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[29],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[30],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[31],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[32],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 142, 134))
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                DecimalnumericArray1M.AssertModel(models[0],_testData[2], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[3], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[4], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[5], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[14], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[15], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[16], false);
                DecimalnumericArray1M.AssertModel(models[15],_testData[17], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[18], false);
                DecimalnumericArray1M.AssertModel(models[17],_testData[19], false);
                DecimalnumericArray1M.AssertModel(models[18],_testData[20], false);
                DecimalnumericArray1M.AssertModel(models[19],_testData[21], false);
                DecimalnumericArray1M.AssertModel(models[20],_testData[22], false);
                DecimalnumericArray1M.AssertModel(models[21],_testData[23], false);
                DecimalnumericArray1M.AssertModel(models[22],_testData[24], false);
                DecimalnumericArray1M.AssertModel(models[23],_testData[25], false);
                DecimalnumericArray1M.AssertModel(models[24],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[25],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[26],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
                DecimalnumericArray1M.AssertModel(models[28],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[29],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[30],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[31],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[32],_testData[34], false);
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

