

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
    Id = 9,
    Value = 
new System.Decimal[3]
{
0.119764770907031m,
0.971436919367398m,
0.88534759139425m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.506143430756906m,
0.44498755084297m,
0.508988848901235m,
0.738583446970775m,
},
},
            new DecimalnumericArray1M
{
    Id = 12,
    Value = 
new System.Decimal[3]
{
0.892335040624179m,
0.880051905780756m,
0.204627833242838m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 3,
    Value = 
new System.Decimal[4]
{
0.292851659762757m,
0.223711021726874m,
0.388790465671118m,
0.912716201274942m,
},
    NullableValue = 
new System.Decimal[4]
{
0.725647605013774m,
0.797650618446861m,
0.583651801954036m,
0.418760278404776m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.951677353327236m,
0.121420053443103m,
0.99235777614252m,
0.921291875070023m,
},
},
            new DecimalnumericArray1M
{
    Id = 15,
    Value = 
new System.Decimal[4]
{
0.761464146647191m,
0.805561385494566m,
0.0322054832008966m,
0.0696598220460758m,
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
0.131683088959763m,
0.548678543689055m,
0.40914235678725m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 12,
    Value = 
new System.Decimal[4]
{
0.650621264199699m,
0.207172182263812m,
0.486494490087178m,
0.162789194765411m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.373347597621925m,
0.67085399346842m,
0.143985510919397m,
},
},
            new DecimalnumericArray1M
{
    Id = 25,
    Value = 
new System.Decimal[3]
{
0.698206099484527m,
0.366232595042777m,
0.413610343628231m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 29,
    Value = 
new System.Decimal[3]
{
0.160455710505816m,
0.456596185754321m,
0.591880705043499m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 16,
    Value = 
new System.Decimal[3]
{
0.724971971352659m,
0.738385863495299m,
0.0413446276202902m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 32,
    Value = 
new System.Decimal[4]
{
0.892351980080228m,
0.860920768064465m,
0.598837312811365m,
0.129851196610246m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.787444697772677m,
0.933368873605261m,
0.0915130344867289m,
},
},
            new DecimalnumericArray1M
{
    Id = 39,
    Value = 
new System.Decimal[4]
{
0.741174055229731m,
0.43353014984249m,
0.542176666164104m,
0.293477862830199m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 18,
    Value = 
new System.Decimal[4]
{
0.932190344345745m,
0.918589840245515m,
0.257294418755372m,
0.447152016203212m,
},
    NullableValue = 
new System.Decimal[3]
{
0.56198802450545m,
0.674051909663132m,
0.381555425834773m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.447042706574773m,
0.0472366842744739m,
0.703629764467529m,
0.453815137076414m,
},
},
            new DecimalnumericArray1M
{
    Id = 40,
    Value = 
new System.Decimal[3]
{
0.30556935713393m,
0.110888461128097m,
0.0443360210865694m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.571759355660302m,
0.0966825776072503m,
0.0587815863850215m,
0.604639075531013m,
},
},
            new DecimalnumericArray1M
{
    Id = 42,
    Value = 
new System.Decimal[3]
{
0.754404600821707m,
0.280910601720788m,
0.977053352472816m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 19,
    Value = 
new System.Decimal[4]
{
0.0221689198534631m,
0.194099155061347m,
0.370208212177326m,
0.889406627506308m,
},
    NullableValue = 
new System.Decimal[4]
{
0.111214442854916m,
0.945328127272591m,
0.429185352089609m,
0.337596996423155m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 48,
    Value = 
new System.Decimal[4]
{
0.405198575073293m,
0.954959405008896m,
0.176850227904782m,
0.68445417936342m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 50,
    Value = 
new System.Decimal[4]
{
0.0935226527530533m,
0.956845964885034m,
0.276049822556238m,
0.653383785199246m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 25,
    Value = 
new System.Decimal[4]
{
0.0824623965411754m,
0.882408376913258m,
0.870942293143699m,
0.617940853472945m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.926110752536672m,
0.173600478569639m,
0.702091485233168m,
0.449734320906015m,
},
},
            new DecimalnumericArray1M
{
    Id = 51,
    Value = 
new System.Decimal[4]
{
0.344259011707835m,
0.735713563601468m,
0.876700112862736m,
0.493646775521254m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.897097352224125m,
0.15226396577784m,
0.555550258187178m,
},
},
            new DecimalnumericArray1M
{
    Id = 52,
    Value = 
new System.Decimal[4]
{
0.442735325664958m,
0.171154629266072m,
0.437766925571717m,
0.900069800974565m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.0903736151582233m,
0.238466002391379m,
0.153396293784966m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.309847175732652m,
0.480444984697436m,
0.14017016514198m,
0.754153182689246m,
},
},
            new DecimalnumericArray1M
{
    Id = 54,
    Value = 
new System.Decimal[3]
{
0.140767317402376m,
0.743298404067322m,
0.275002201143181m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 56,
    Value = 
new System.Decimal[3]
{
0.48744296954898m,
0.791914556783828m,
0.871091507597735m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 28,
    Value = 
new System.Decimal[4]
{
0.622628360889363m,
0.640541235821513m,
0.663012407957462m,
0.538248591246112m,
},
    NullableValue = 
new System.Decimal[3]
{
0.0480770382293139m,
0.331219022816933m,
0.959626769959694m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 60,
    Value = 
new System.Decimal[3]
{
0.547370982008635m,
0.289749689267967m,
0.859318966130972m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.457427518223088m,
0.29680464106957m,
0.281163791611776m,
0.616313939194348m,
},
},
            new DecimalnumericArray1M
{
    Id = 62,
    Value = 
new System.Decimal[4]
{
0.394353404620237m,
0.352593813480431m,
0.652050729391967m,
0.826942046410504m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 34,
    Value = 
new System.Decimal[3]
{
0.462185633741355m,
0.523604741758916m,
0.513761882872576m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.0568589586345256m,
0.745811408054578m,
0.213557296927492m,
0.99508512868407m,
},
},
            new DecimalnumericArray1M
{
    Id = 70,
    Value = 
new System.Decimal[3]
{
0.944520718154711m,
0.952654819817861m,
0.10774628253384m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.182628077365207m,
0.642896634347323m,
0.652867741442061m,
0.295851125590448m,
},
},
            new DecimalnumericArray1M
{
    Id = 72,
    Value = 
new System.Decimal[3]
{
0.211115144078851m,
0.841975296766531m,
0.512017443128126m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 36,
    Value = 
new System.Decimal[4]
{
0.95136935061125m,
0.364209852268731m,
0.245280830013437m,
0.175998789575891m,
},
    NullableValue = 
new System.Decimal[3]
{
0.798228729064736m,
0.234915120262477m,
0.264435662608987m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.397492296622074m,
0.649436750232954m,
0.277230085910339m,
0.632062887155686m,
},
},
            new DecimalnumericArray1M
{
    Id = 79,
    Value = 
new System.Decimal[4]
{
0.181263280097834m,
0.197152006521835m,
0.794223391626098m,
0.256318597221094m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.67779130723896m,
0.717433713296852m,
0.33662247126075m,
0.463473362875597m,
},
},
            new DecimalnumericArray1M
{
    Id = 88,
    Value = 
new System.Decimal[3]
{
0.0468189341640739m,
0.926980430340432m,
0.160361638448633m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 43,
    Value = 
new System.Decimal[3]
{
0.928704633904001m,
0.629398895294051m,
0.231656347565994m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0576521552725738m,
0.0054121732447161m,
0.682848945866661m,
0.623306097833984m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.0902269739784445m,
0.787029981814286m,
0.453647380659318m,
0.0835790778493187m,
},
},
            new DecimalnumericArray1M
{
    Id = 90,
    Value = 
new System.Decimal[4]
{
0.665267110552613m,
0.769604707637352m,
0.94957230276328m,
0.800718485212425m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.960869150872399m,
0.699365180028484m,
0.0559117993223566m,
},
},
            new DecimalnumericArray1M
{
    Id = 96,
    Value = 
new System.Decimal[3]
{
0.696253770699201m,
0.126476630198656m,
0.708258883430364m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 51,
    Value = 
new System.Decimal[3]
{
0.323262328144513m,
0.16582678158128m,
0.91743722858592m,
},
    NullableValue = 
new System.Decimal[3]
{
0.215614757036323m,
0.309669065503272m,
0.0792522626832684m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.947506258909404m,
0.0812291677597132m,
0.041308887958735m,
},
},
            new DecimalnumericArray1M
{
    Id = 103,
    Value = 
new System.Decimal[3]
{
0.871509088543432m,
0.24196238884918m,
0.971277640231907m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 110,
    Value = 
new System.Decimal[4]
{
0.547005384623096m,
0.741277840776602m,
0.922565148129522m,
0.721142616095499m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 59,
    Value = 
new System.Decimal[3]
{
0.235742345939181m,
0.835184338353069m,
0.298133806500548m,
},
    NullableValue = 
new System.Decimal[4]
{
0.257735649874308m,
0.0746394205431814m,
0.431859660339794m,
0.51597823602976m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.428576993435814m,
0.297347882681538m,
0.667020281542024m,
0.142486833443169m,
},
},
            new DecimalnumericArray1M
{
    Id = 114,
    Value = 
new System.Decimal[3]
{
0.625077227727068m,
0.906179877265888m,
0.664166798010702m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.635516084416756m,
0.16653216547831m,
0.93317032797429m,
0.472814955803835m,
},
},
            new DecimalnumericArray1M
{
    Id = 122,
    Value = 
new System.Decimal[4]
{
0.244287924948233m,
0.351124677101896m,
0.482391677388645m,
0.438198603111391m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 67,
    Value = 
new System.Decimal[4]
{
0.370729540945039m,
0.998541111433303m,
0.58928123151826m,
0.106137797824223m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 131,
    Value = 
new System.Decimal[4]
{
0.564616435999599m,
0.789117402597927m,
0.18165976885749m,
0.00541342975718462m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 135,
    Value = 
new System.Decimal[3]
{
0.351653426022552m,
0.46932477127536m,
0.698435136195448m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 72,
    Value = 
new System.Decimal[3]
{
0.759328910340849m,
0.422968175334105m,
0.623233672223676m,
},
    NullableValue = null,
},
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
0.787444697772677m,
0.933368873605261m,
0.0915130344867289m,
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
new System.Decimal[4]
{
0.447042706574773m,
0.0472366842744739m,
0.703629764467529m,
0.453815137076414m,
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
new System.Decimal[4]
{
0.571759355660302m,
0.0966825776072503m,
0.0587815863850215m,
0.604639075531013m,
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
new System.Decimal[4]
{
0.926110752536672m,
0.173600478569639m,
0.702091485233168m,
0.449734320906015m,
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 42, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 88, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 56, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[29], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 79, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 110, 54))
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 110, 79))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[29], false);
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
DecimalnumericArray1M.AssertModel(models[0],_testData[2], false);DecimalnumericArray1M.AssertModel(models[1],_testData[3], false);DecimalnumericArray1M.AssertModel(models[2],_testData[4], false);DecimalnumericArray1M.AssertModel(models[3],_testData[5], false);DecimalnumericArray1M.AssertModel(models[4],_testData[6], false);DecimalnumericArray1M.AssertModel(models[5],_testData[7], false);DecimalnumericArray1M.AssertModel(models[6],_testData[8], false);DecimalnumericArray1M.AssertModel(models[7],_testData[9], false);DecimalnumericArray1M.AssertModel(models[8],_testData[10], false);DecimalnumericArray1M.AssertModel(models[9],_testData[11], false);DecimalnumericArray1M.AssertModel(models[10],_testData[12], false);DecimalnumericArray1M.AssertModel(models[11],_testData[13], false);DecimalnumericArray1M.AssertModel(models[12],_testData[14], false);DecimalnumericArray1M.AssertModel(models[13],_testData[15], false);DecimalnumericArray1M.AssertModel(models[14],_testData[16], false);DecimalnumericArray1M.AssertModel(models[15],_testData[17], false);DecimalnumericArray1M.AssertModel(models[16],_testData[18], false);DecimalnumericArray1M.AssertModel(models[17],_testData[19], false);DecimalnumericArray1M.AssertModel(models[18],_testData[20], false);DecimalnumericArray1M.AssertModel(models[19],_testData[21], false);DecimalnumericArray1M.AssertModel(models[20],_testData[22], false);DecimalnumericArray1M.AssertModel(models[21],_testData[23], false);DecimalnumericArray1M.AssertModel(models[22],_testData[24], false);DecimalnumericArray1M.AssertModel(models[23],_testData[25], false);DecimalnumericArray1M.AssertModel(models[24],_testData[26], false);DecimalnumericArray1M.AssertModel(models[25],_testData[27], false);DecimalnumericArray1M.AssertModel(models[26],_testData[28], false);DecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
DecimalnumericArray1M.AssertModel(models[0],_testData[9], false);DecimalnumericArray1M.AssertModel(models[1],_testData[10], false);DecimalnumericArray1M.AssertModel(models[2],_testData[11], false);DecimalnumericArray1M.AssertModel(models[3],_testData[12], false);DecimalnumericArray1M.AssertModel(models[4],_testData[13], false);DecimalnumericArray1M.AssertModel(models[5],_testData[14], false);DecimalnumericArray1M.AssertModel(models[6],_testData[15], false);DecimalnumericArray1M.AssertModel(models[7],_testData[16], false);DecimalnumericArray1M.AssertModel(models[8],_testData[17], false);DecimalnumericArray1M.AssertModel(models[9],_testData[18], false);DecimalnumericArray1M.AssertModel(models[10],_testData[19], false);DecimalnumericArray1M.AssertModel(models[11],_testData[20], false);DecimalnumericArray1M.AssertModel(models[12],_testData[21], false);DecimalnumericArray1M.AssertModel(models[13],_testData[22], false);DecimalnumericArray1M.AssertModel(models[14],_testData[23], false);DecimalnumericArray1M.AssertModel(models[15],_testData[24], false);DecimalnumericArray1M.AssertModel(models[16],_testData[25], false);DecimalnumericArray1M.AssertModel(models[17],_testData[26], false);DecimalnumericArray1M.AssertModel(models[18],_testData[27], false);DecimalnumericArray1M.AssertModel(models[19],_testData[28], false);DecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
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

