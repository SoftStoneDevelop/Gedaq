

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
    internal partial interface IDoubleMArraydouble_precisionMMArrayD1
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMMArrayD1 : IDoubleMArraydouble_precisionMMArrayD1
    {


#region TestData

        private readonly Doubledouble_precisionMMArrayD1E1M[] _testData = new Doubledouble_precisionMMArrayD1E1M[]
        {
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 2,
    Value = 
new System.Double[3]
{
0.3190654486506207d,
0.14298359019864115d,
0.7010997000406206d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8861732980449445d,
0.0606052158048197d,
0.185593692082205d,
0.36559249704532426d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Double[3]
{
0.03227468722353266d,
0.22955718550585413d,
0.0021166135195028746d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Double[3]
{
0.3698064461087166d,
0.445718461476176d,
0.9421866642347131d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Double[4]
{
0.16379913999342166d,
0.35486760622038493d,
0.23671190258474828d,
0.04366125509521379d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Double[3]
{
0.5069634537398288d,
0.053715587541646626d,
0.2070743898036621d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Double[4]
{
0.08220660198514385d,
0.5257851132908546d,
0.6489801206945212d,
0.08643522279165516d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Double[4]
{
0.5276005420108195d,
0.3386204197738061d,
0.19166405040334256d,
0.5384656081477572d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Double[4]
{
0.9180471080437413d,
0.6624201437932822d,
0.9849927744322453d,
0.5645399762112433d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Double[4]
{
0.7260900604108366d,
0.4368105997033007d,
0.6646203812928093d,
0.3784014485942232d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.06475589975751561d,
0.46771052233451227d,
0.8813688614711234d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Double[3]
{
0.6183434220776659d,
0.5234236947855417d,
0.7204533455249167d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Double[3]
{
0.04674256186076009d,
0.4800202665536104d,
0.412879000531862d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Double[4]
{
0.015508857918517527d,
0.9666910598875748d,
0.0025448471124919214d,
0.382990886461386d,
},
    NullableValue = 
new System.Double[4]
{
0.27098278576564594d,
0.23736748928967955d,
0.3616650720651684d,
0.01807454107514961d,
},
},
    NullableValue = 
new System.Double[3]
{
0.7397219239897415d,
0.42254797157045276d,
0.8182578458407459d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Double[3]
{
0.7167347089321255d,
0.8358001118543222d,
0.4187737080082128d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Double[4]
{
0.34176765990463154d,
0.21949713119526248d,
0.25578218944024433d,
0.4928390899884393d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Double[3]
{
0.7468728917535798d,
0.5583637157351857d,
0.8476580200201183d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Double[3]
{
0.5237332001610746d,
0.7816732693183481d,
0.8182247358815364d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Double[4]
{
0.7105679896673333d,
0.4885802808030508d,
0.42394674485635087d,
0.9565650002341524d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Double[4]
{
0.035394408745495265d,
0.7215175022047329d,
0.2567153910739082d,
0.6891850120618571d,
},
    NullableValue = 
new System.Double[4]
{
0.39969332513671285d,
0.10932302147906425d,
0.00974073959969457d,
0.5363975372583837d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Double[3]
{
0.42989089193017227d,
0.6390251241984897d,
0.6532321732479917d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.5655989385903799d,
0.501658379941206d,
0.2475398153867593d,
0.16402979812907603d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Double[4]
{
0.23601662227301035d,
0.2704486138862676d,
0.042912750224163965d,
0.3112956418873436d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Double[3]
{
0.41784404955947607d,
0.11703552574076337d,
0.011908770656916201d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Double[3]
{
0.2482923362890439d,
0.05240947341075508d,
0.2046455987848067d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.6383479514250945d,
0.792029764135571d,
0.8341433008286151d,
0.8399308733192541d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Double[4]
{
0.298509639170112d,
0.9439332238500627d,
0.784990678642723d,
0.8737372530917423d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Double[3]
{
0.6111652184170532d,
0.05029823508796538d,
0.8883172279502171d,
},
    NullableValue = 
new System.Double[3]
{
0.016154651491004257d,
0.06887326718078379d,
0.45442174556716164d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Double[3]
{
0.6739332618065329d,
0.007433091748268783d,
0.3146179850373385d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.604873997538074d,
0.8539615833674158d,
0.395904505397896d,
0.8830292068069853d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.4911662960576123d,
0.2950952051885921d,
0.26206358145979003d,
0.30408683588879293d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Double[3]
{
0.21668903379318993d,
0.7898692446850586d,
0.8924865713278094d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Double[4]
{
0.5275348239700198d,
0.223594077327811d,
0.1205787436488912d,
0.131084958029705d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Double[4]
{
0.7108500787373129d,
0.6317878053433525d,
0.9202757442761061d,
0.0496797989471206d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Double[3]
{
0.8396962056879139d,
0.03872551301494087d,
0.7617904659609586d,
},
    NullableValue = 
new System.Double[4]
{
0.6100401550941241d,
0.6598286520353802d,
0.8790544926229757d,
0.8117230740272768d,
},
},
    NullableValue = 
new System.Double[3]
{
0.9247804060478223d,
0.23424949918319227d,
0.7265074539831012d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Double[3]
{
0.630387350203933d,
0.5777534018795205d,
0.259776668716464d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Double[3]
{
0.20562690944786421d,
0.3507148323098429d,
0.49047205221419454d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Double[4]
{
0.7553070411735678d,
0.4876819573572868d,
0.3668178468914408d,
0.3176295869590866d,
},
    NullableValue = 
new System.Double[4]
{
0.5282851898337763d,
0.015210157744253827d,
0.8538067254066918d,
0.6086040619789643d,
},
},
    NullableValue = 
new System.Double[4]
{
0.4973082587352601d,
0.8001316735492122d,
0.9558628643498561d,
0.22246084512372988d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 110,
    Value = 
new System.Double[4]
{
0.6370746947044028d,
0.16940180357090218d,
0.5044798277225249d,
0.12331327113674351d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Double[4]
{
0.9762528268180187d,
0.5901647172404797d,
0.6994956025642615d,
0.7262382338730595d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Double[4]
{
0.12712754482193867d,
0.09726597475357146d,
0.33195298116521055d,
0.7181883082503642d,
},
    NullableValue = 
new System.Double[3]
{
0.7715343698580677d,
0.721681725316193d,
0.43877473211962625d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Double[3]
{
0.8850509683822584d,
0.9898151145022034d,
0.3856649456059046d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.41142497424550173d,
0.6358644587722743d,
0.9263937388052911d,
0.3300348155637667d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Double[4]
{
0.8982658334511482d,
0.009614983468621774d,
0.5454161297643058d,
0.2475823504958935d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Double[3]
{
0.9861698922502705d,
0.26465142084731696d,
0.34971960825985926d,
},
    NullableValue = 
new System.Double[3]
{
0.30954110964800874d,
0.46767401787714225d,
0.5261137889998221d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Double[4]
{
0.1521741562425618d,
0.7563281762572709d,
0.8149518216346788d,
0.3421952263368797d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3031106581232882d,
0.14875945499274879d,
0.6315725503193986d,
0.4797645343575293d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Double[4]
{
0.4659848041026804d,
0.7126434361763394d,
0.881620889737541d,
0.06162833333716344d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Double[3]
{
0.209710565367204d,
0.8949482866529976d,
0.08394880913554514d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Double[3]
{
0.8684125806331263d,
0.6355591239618159d,
0.3142525091874604d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Double[3]
{
0.24813216238605884d,
0.8675369475742174d,
0.20005317729070804d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Double[3]
{
0.7593373903273751d,
0.05101012968615448d,
0.9379491538699546d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.8476997701910954d,
0.048051143401492635d,
0.36905087356060773d,
0.9991659751516658d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Double[4]
{
0.6612128433761914d,
0.16402674722723487d,
0.8471517480022136d,
0.7849958853015405d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.37825773493617265d,
0.6987554079968384d,
0.7329169195922084d,
0.8020497706390941d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Double[3]
{
0.46327262465747276d,
0.5790886935904026d,
0.4251273096829059d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Double[4]
{
0.2582004668255198d,
0.12898688024152016d,
0.47698659001911714d,
0.7748637966066456d,
},
    NullableValue = 
new System.Double[3]
{
0.7057537992333593d,
0.1320297516495833d,
0.5724875603847797d,
},
},
    NullableValue = 
new System.Double[4]
{
0.3879725222204421d,
0.2130788201462055d,
0.2008001755532821d,
0.007167020577881211d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Double[4]
{
0.34314365191379304d,
0.22609795265048216d,
0.3350452008910192d,
0.7909325335958461d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Double[3]
{
0.8968761950266091d,
0.21861726043453156d,
0.11881513087919937d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Double[3]
{
0.5548747091033518d,
0.4891177117687512d,
0.41957639727541707d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Double[4]
{
0.9479298860597528d,
0.1284101244228928d,
0.38368398154593775d,
0.9573881390113461d,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
INSERT INTO public.doubledouble_precisionmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)), 
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
                methodParametrName: "doubledouble_precisionmmarrayd1e1mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.06475589975751561d,
0.46771052233451227d,
0.8813688614711234d,
}));
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.7397219239897415d,
0.42254797157045276d,
0.8182578458407459d,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                methodParametrName: "doubledouble_precisionmmarrayd1e1mi_id", 
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
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD1E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD1E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 76;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 96;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 34, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 64, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 6, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 17, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 131, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 76, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 139, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 89, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MI),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1M),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
FROM public.binary_doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.binary_doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI), typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

