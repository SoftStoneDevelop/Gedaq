

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
    Id = 4,
    Value = 
new System.Decimal[4]
{
0.237347750519638m,
0.94133480722267m,
0.511322319338373m,
0.766457870289738m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.248779635662421m,
0.464265355132322m,
0.845594340086429m,
},
},
            new DecimalnumericArray1M
{
    Id = 10,
    Value = 
new System.Decimal[3]
{
0.671799502644704m,
0.215218469422393m,
0.0703597993677275m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 4,
    Value = 
new System.Decimal[3]
{
0.480173601822875m,
0.17270290169475m,
0.490495352311914m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.39392003722792m,
0.607981792938235m,
0.0523771084434808m,
0.485414794595181m,
},
},
            new DecimalnumericArray1M
{
    Id = 12,
    Value = 
new System.Decimal[3]
{
0.751628215668247m,
0.906525164263893m,
0.513410733186083m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.973008983501007m,
0.018694755612143m,
0.736574827837732m,
},
},
            new DecimalnumericArray1M
{
    Id = 14,
    Value = 
new System.Decimal[4]
{
0.640403231170754m,
0.000657637386408116m,
0.566300382630611m,
0.44593585485447m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 5,
    Value = 
new System.Decimal[3]
{
0.783646791484128m,
0.134636253521864m,
0.0749653556451695m,
},
    NullableValue = 
new System.Decimal[3]
{
0.750926392404708m,
0.675596577284212m,
0.713300240977238m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 20,
    Value = 
new System.Decimal[3]
{
0.249454253833009m,
0.746417269017123m,
0.661475572510816m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.437468999080134m,
0.917924825738401m,
0.345332314655935m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 8,
    Value = 
new System.Decimal[3]
{
0.367569428594275m,
0.822788679959366m,
0.131859326118587m,
},
    NullableValue = 
new System.Decimal[4]
{
0.56796905105399m,
0.555581281669386m,
0.544983545921175m,
0.284372318004589m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.45838828397586m,
0.249925473917329m,
0.312120514138387m,
0.382639710436629m,
},
},
            new DecimalnumericArray1M
{
    Id = 34,
    Value = 
new System.Decimal[4]
{
0.772070788115478m,
0.823702713890005m,
0.828562417058103m,
0.023823717865753m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 42,
    Value = 
new System.Decimal[3]
{
0.550827706780479m,
0.558020191704895m,
0.480040732483303m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 12,
    Value = 
new System.Decimal[4]
{
0.20584376686474m,
0.092823870003206m,
0.946927807164479m,
0.771150830050659m,
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
0.456177357224782m,
0.454352395751698m,
0.829900196126394m,
0.652868013437645m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.312713238094542m,
0.520796431574432m,
0.286966505639718m,
},
},
            new DecimalnumericArray1M
{
    Id = 50,
    Value = 
new System.Decimal[3]
{
0.0504303109637301m,
0.930578203812703m,
0.172294070809697m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 17,
    Value = 
new System.Decimal[4]
{
0.685963219066495m,
0.442257768609053m,
0.549756580133198m,
0.295125055911871m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 51,
    Value = 
new System.Decimal[3]
{
0.152910234772522m,
0.00420558935172444m,
0.137777041845557m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 57,
    Value = 
new System.Decimal[4]
{
0.49604821581462m,
0.570728174132655m,
0.656398404454297m,
0.796478134798513m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 24,
    Value = 
new System.Decimal[3]
{
0.616460483701297m,
0.811860808499398m,
0.882726575842562m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.919531654600586m,
0.938625283041212m,
0.306289152860168m,
},
},
            new DecimalnumericArray1M
{
    Id = 62,
    Value = 
new System.Decimal[4]
{
0.16913000154142m,
0.173591741452483m,
0.303990356324132m,
0.0729080914099921m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0367518570980897m,
0.817846030669039m,
0.476707836431215m,
},
},
            new DecimalnumericArray1M
{
    Id = 65,
    Value = 
new System.Decimal[4]
{
0.738332057497065m,
0.502669754412838m,
0.0371790328262732m,
0.378227558978384m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 30,
    Value = 
new System.Decimal[4]
{
0.558560632056142m,
0.0962835305135936m,
0.217294123943673m,
0.855919004076179m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.681048732197436m,
0.199755569675143m,
0.574028287372636m,
},
},
            new DecimalnumericArray1M
{
    Id = 66,
    Value = 
new System.Decimal[3]
{
0.931910294210005m,
0.414205544202334m,
0.461210726463436m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 71,
    Value = 
new System.Decimal[3]
{
0.305269230829554m,
0.177707308696337m,
0.982396070437434m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 37,
    Value = 
new System.Decimal[3]
{
0.155014863158913m,
0.753558705704568m,
0.402778313620371m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.621943251995774m,
0.66355852278909m,
0.202291864400027m,
0.262101825019121m,
},
},
            new DecimalnumericArray1M
{
    Id = 74,
    Value = 
new System.Decimal[3]
{
0.670800124814564m,
0.427599677355409m,
0.188814511511038m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 79,
    Value = 
new System.Decimal[3]
{
0.474096574758046m,
0.328390091302762m,
0.155331683600695m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 44,
    Value = 
new System.Decimal[3]
{
0.917586309102761m,
0.501824918418594m,
0.572163441990998m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.71729756872433m,
0.327823904323026m,
0.771282776166858m,
0.345577888880945m,
},
},
            new DecimalnumericArray1M
{
    Id = 86,
    Value = 
new System.Decimal[4]
{
0.745010838314189m,
0.441569085359148m,
0.542352386523418m,
0.273306180503985m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 94,
    Value = 
new System.Decimal[3]
{
0.716182798469351m,
0.0536639892035107m,
0.580439882841424m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 51,
    Value = 
new System.Decimal[4]
{
0.20938164590495m,
0.641483425688033m,
0.913068004520581m,
0.172018599808412m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.851535027584641m,
0.783287072887706m,
0.558781265092967m,
0.301605901258812m,
},
},
            new DecimalnumericArray1M
{
    Id = 98,
    Value = 
new System.Decimal[4]
{
0.958538388697172m,
0.388191506075665m,
0.125120678616139m,
0.791945967127997m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 101,
    Value = 
new System.Decimal[4]
{
0.226556891272957m,
0.901999941405906m,
0.542049102736356m,
0.76056820606402m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 60,
    Value = 
new System.Decimal[3]
{
0.880402140345192m,
0.680646629885011m,
0.710944711881654m,
},
    NullableValue = 
new System.Decimal[3]
{
0.44908732935498m,
0.445568984074641m,
0.761315395388227m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 109,
    Value = 
new System.Decimal[3]
{
0.195104251019653m,
0.93134288263732m,
0.984393344509132m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 117,
    Value = 
new System.Decimal[4]
{
0.910560464116362m,
0.310305566767095m,
0.813268886914051m,
0.833115755326003m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 69,
    Value = 
new System.Decimal[3]
{
0.738845375852952m,
0.110144704111853m,
0.513193454464619m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 118,
    Value = 
new System.Decimal[4]
{
0.563624719829703m,
0.693730001319619m,
0.530609971504515m,
0.775654915865722m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 121,
    Value = 
new System.Decimal[4]
{
0.143370765135579m,
0.950839580747986m,
0.569308102573691m,
0.202108072335388m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 72,
    Value = 
new System.Decimal[3]
{
0.522987116985297m,
0.344090897302581m,
0.716441503104782m,
},
    NullableValue = 
new System.Decimal[4]
{
0.257990697172442m,
0.17676755010672m,
0.510705759945903m,
0.782643856643826m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 122,
    Value = 
new System.Decimal[4]
{
0.183253371423074m,
0.365367132950698m,
0.0958670434266878m,
0.747295679877518m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.974118347721271m,
0.734296074195201m,
0.234539380697584m,
0.651914402988277m,
},
},
            new DecimalnumericArray1M
{
    Id = 128,
    Value = 
new System.Decimal[3]
{
0.554430927227307m,
0.620113727930648m,
0.783839408885006m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 73,
    Value = 
new System.Decimal[3]
{
0.0170170370625286m,
0.756222348606677m,
0.0558445933092275m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.862803542633674m,
0.103938477409014m,
0.636050938496922m,
},
},
            new DecimalnumericArray1M
{
    Id = 134,
    Value = 
new System.Decimal[4]
{
0.339870799560278m,
0.387823074911339m,
0.214897543963906m,
0.380627728481223m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 135,
    Value = 
new System.Decimal[4]
{
0.758538351662431m,
0.660473147812934m,
0.185630116673986m,
0.288871228638897m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 77,
    Value = 
new System.Decimal[3]
{
0.140892597195806m,
0.293915032648641m,
0.624387092584586m,
},
    NullableValue = 
new System.Decimal[4]
{
0.104618237844741m,
0.831214517767768m,
0.566020498141095m,
0.175930000400294m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.270804879370308m,
0.758754019347406m,
0.222076114061646m,
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
0.45838828397586m,
0.249925473917329m,
0.312120514138387m,
0.382639710436629m,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.312713238094542m,
0.520796431574432m,
0.286966505639718m,
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.919531654600586m,
0.938625283041212m,
0.306289152860168m,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                parametr1.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 42, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 51, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 34, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 122, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[29], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 121, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
DecimalnumericArray1M.AssertModel(models[0],_testData[18], false);DecimalnumericArray1M.AssertModel(models[1],_testData[19], false);DecimalnumericArray1M.AssertModel(models[2],_testData[20], false);DecimalnumericArray1M.AssertModel(models[3],_testData[21], false);DecimalnumericArray1M.AssertModel(models[4],_testData[22], false);DecimalnumericArray1M.AssertModel(models[5],_testData[23], false);DecimalnumericArray1M.AssertModel(models[6],_testData[24], false);DecimalnumericArray1M.AssertModel(models[7],_testData[25], false);DecimalnumericArray1M.AssertModel(models[8],_testData[26], false);DecimalnumericArray1M.AssertModel(models[9],_testData[27], false);DecimalnumericArray1M.AssertModel(models[10],_testData[28], false);DecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
DecimalnumericArray1M.AssertModel(models[0],_testData[20], false);DecimalnumericArray1M.AssertModel(models[1],_testData[21], false);DecimalnumericArray1M.AssertModel(models[2],_testData[22], false);DecimalnumericArray1M.AssertModel(models[3],_testData[23], false);DecimalnumericArray1M.AssertModel(models[4],_testData[24], false);DecimalnumericArray1M.AssertModel(models[5],_testData[25], false);DecimalnumericArray1M.AssertModel(models[6],_testData[26], false);DecimalnumericArray1M.AssertModel(models[7],_testData[27], false);DecimalnumericArray1M.AssertModel(models[8],_testData[28], false);DecimalnumericArray1M.AssertModel(models[9],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                await ((IDecimalArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(DecimalnumericArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray1M>(15);

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
                ((IDecimalArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalnumericArray1M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDecimalArraynumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalnumericArray1M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[14], false);
                DecimalnumericArray1M.AssertModel(models[15],_testData[15], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[16], false);
                DecimalnumericArray1M.AssertModel(models[17],_testData[17], false);
                DecimalnumericArray1M.AssertModel(models[18],_testData[18], false);
                DecimalnumericArray1M.AssertModel(models[19],_testData[19], false);
                DecimalnumericArray1M.AssertModel(models[20],_testData[20], false);
                DecimalnumericArray1M.AssertModel(models[21],_testData[21], false);
                DecimalnumericArray1M.AssertModel(models[22],_testData[22], false);
                DecimalnumericArray1M.AssertModel(models[23],_testData[23], false);
                DecimalnumericArray1M.AssertModel(models[24],_testData[24], false);
                DecimalnumericArray1M.AssertModel(models[25],_testData[25], false);
                DecimalnumericArray1M.AssertModel(models[26],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[27],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[28],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalArraynumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

