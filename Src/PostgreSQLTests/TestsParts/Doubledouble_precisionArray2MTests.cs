

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09556908685782917d,

0.20776598033275162d,

0.7250168710494909d,

0.7041053838631324d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4683254925110639d,

0.35557472295327064d,

0.19148057433363086d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5262634614901979d,

0.1510226560854202d,

0.7151659407110584d,

0.049500489691618355d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.756173669660476d,

0.35379813605099675d,

0.0653356811660678d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7370993398377761d,

0.4828165053008383d,

0.6741206840678933d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3544149175014325d,

0.5193056698138189d,

0.544367997803828d,

0.5267680635202137d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4040498732672112d,

0.5190431603593871d,

0.7151079908404275d,

0.8831856294275302d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4459242012463428d,

0.636151128784908d,

0.22931405185043552d,

0.12798392591095353d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7662878846250031d,

0.013284377722371787d,

0.33851437260940587d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7896076735937942d,

0.1418017362273234d,

0.029675904577459944d,

0.03465553648281028d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8965320371998869d,

0.37452113679757726d,

0.05149990251476333d,

0.683329697079895d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.17165141736192335d,

0.2522303359831781d,

0.8178405198198099d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.030959137933995406d,

0.28319051250412586d,

0.8605524533483215d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8985182282213114d,

0.025994524609243785d,

0.4021636234902014d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2254001590825545d,

0.8398797802165455d,

0.14515928699849112d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33927894182089746d,

0.926838127130904d,

0.15445369276980458d,

0.1519954729383891d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28840928814643674d,

0.7209732374174368d,

0.40190808976093917d,

0.05206258415953591d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33119578030043295d,

0.6926776455629923d,

0.22194386496816876d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8577084246424115d,

0.9971473240512082d,

0.1975216960794477d,

0.690258691058328d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9005631364585484d,

0.17455033410532228d,

0.5721697438675309d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2587864321108343d,

0.13716461359641896d,

0.034645760795457115d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3165937008057702d,

0.6073056043775784d,

0.4949965635702144d,

0.6632605783610284d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5695014602675437d,

0.7288091441496243d,

0.16405768174488689d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8233592879950747d,

0.9452738711219274d,

0.4040017776887884d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4253249438020301d,

0.9727180162965359d,

0.8429586943558817d,

0.42403836198283096d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9587826553077922d,

0.8626517282853604d,

0.10480569592975508d,

0.09574921833119554d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.00338598399101131d,

0.06758876647497614d,

0.11365472077122862d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9241719540142835d,

0.20357130917974342d,

0.919578525646371d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19158898513843514d,

0.17322331113494782d,

0.1225338023682001d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9286973630210478d,

0.278628716878612d,

0.4888361106835657d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7849191591466239d,

0.8595106865384734d,

0.04192576989842611d,

0.28470427789809993d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6574545357700126d,

0.443586467551626d,

0.6511107610636948d,

0.25228093216229175d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.893065722028954d,

0.7805936098718789d,

0.5415847319395276d,

0.9972226795434279d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.38126983145300397d,

0.34767647587197625d,

0.7304993777718758d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12910359205345745d,

0.44262698059876715d,

0.16181323857247087d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3582073606887153d,

0.6259259362796277d,

0.7674407579423366d,

0.7335172545822666d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.663823973810255d,

0.8625951692653908d,

0.7235525318495788d,

0.5901277812119989d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3337758541428788d,

0.45231284952487716d,

0.8261714138124248d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5210916674176601d,

0.4230423640190296d,

0.37726951173469925d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3066029210972091d,

0.5811913086618362d,

0.9449489106171554d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5685105785819718d,

0.4836524985403561d,

0.7517531070993984d,

0.5560655449600662d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.35891910242843417d,

0.7646751615454974d,

0.06309008741245248d,

0.9684352943691976d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.641880308306491d,

0.6081841956817919d,

0.07715146346523771d,

0.6918603547650073d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.27921886686158526d,

0.7930841555258806d,

0.1989946574640007d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5281334769875561d,

0.7879789790862737d,

0.6686282311374693d,

0.9664284516258652d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2836958388983438d,

0.9223166496896039d,

0.3487003101660864d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0826322799956678d,

0.07775442035950031d,

0.6234165357735388d,

0.6768762569691514d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1647027426978921d,

0.7592104850651002d,

0.8508430799678399d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2643059891985612d,

0.11906479252375424d,

0.15835228452635308d,

0.09065421007234375d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7497601746331976d,

0.8363793417057211d,

0.9683012339794902d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.932464310778863d,

0.7963077426647165d,

0.17970910903377657d,

0.7668075464399727d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19208767421616635d,

0.9372595344987613d,

0.7616840112461076d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.004651385993235446d,

0.8629449447488652d,

0.9178539739866889d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7763489180221858d,

0.8656096522693838d,

0.4313024787190616d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5606832607451044d,

0.8667147251537636d,

0.800854363583519d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9858284466772383d,

0.7169348216451443d,

0.18911027263118851d,

0.20651289337854872d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13518904928856523d,

0.5619748685877111d,

0.5168072078894196d,

0.20676487984159997d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4281352620637343d,

0.1853550298909984d,

0.827297205100516d,

0.3848558726743496d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.21966110594558264d,

0.9220529894512144d,

0.9182700656907623d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06958262586660258d,

0.3330172758545499d,

0.4129338419456976d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6291845295470848d,

0.10592920348424772d,

0.1651268477985185d,

0.8729672415763546d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9259350738103633d,

0.17861017858080097d,

0.3598900187591817d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9640696413995217d,

0.5249805525731659d,

0.40221551975966763d,

0.19146153862538662d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7046984854870956d,

0.42531552642306636d,

0.8664676309013306d,

0.17128318561439027d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7937306971579196d,

0.22830512801461356d,

0.43620522322105626d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5806769013002094d,

0.16877291104326264d,

0.09210598854654228d,

0.9350249119616156d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9733758618541926d,

0.3944996471796537d,

0.07694276495264663d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5445344365363778d,

0.3367123920072521d,

0.31054225554077686d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6734381356558529d,

0.8709269886374436d,

0.48918529655227605d,

0.3963130594708004d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8047183300886247d,

0.6691930734605172d,

0.5079131180359747d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4139228739618581d,

0.3765509432594679d,

0.1686694792103418d,

0.6680816513547261d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.805025073809765d,

0.9519967260632227d,

0.22835689332165054d,

0.034864118108779096d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9894650303361333d,

0.7954667293874912d,

0.7145404158899602d,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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

                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[3], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[4], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[5], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[6], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[7], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[8], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[9], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[10], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[6], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[7], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[8], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[9], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[10], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
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

                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 100, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 80, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelBatchAsync(connection, 52, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
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
                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelBatch(connection, 64, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2M>(15);

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
                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

