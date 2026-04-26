

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
    Id = 4,
    Value = 
new System.Double[4]
{
0.47368207736067247d,
0.4950759284480959d,
0.42516863594627907d,
0.4025021518825983d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.4809944067683378d,
0.3227776867290125d,
0.457083291465755d,
0.5654210835401924d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 13,
    Value = 
new System.Double[4]
{
0.5221508294986147d,
0.27180773510498d,
0.7838147897074179d,
0.7278018192351442d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 9,
    Value = 
new System.Double[3]
{
0.7962200793642883d,
0.03649976893911133d,
0.808878535267021d,
},
    NullableValue = 
new System.Double[4]
{
0.6196332501483952d,
0.7309269260498351d,
0.4672151632189858d,
0.7808948646848883d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 18,
    Value = 
new System.Double[3]
{
0.39188747302722626d,
0.83803009773134d,
0.6129715288375766d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 26,
    Value = 
new System.Double[3]
{
0.5667730316706945d,
0.8304976293335835d,
0.1648326434431321d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 12,
    Value = 
new System.Double[4]
{
0.4295353497836192d,
0.3869532290725636d,
0.8425620620165386d,
0.5421032846984528d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 31,
    Value = 
new System.Double[4]
{
0.8873135063019685d,
0.8740134511197458d,
0.9285926162950607d,
0.5061756074523628d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 32,
    Value = 
new System.Double[3]
{
0.4842874801211773d,
0.08316627936614973d,
0.6696528384453331d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 21,
    Value = 
new System.Double[3]
{
0.4288216642596797d,
0.033079173356622915d,
0.4768040105410609d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 34,
    Value = 
new System.Double[4]
{
0.3250567363943213d,
0.23368128450903525d,
0.6773643366315231d,
0.41875009803626273d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.5473118452450788d,
0.19181393841710692d,
0.09531754164315509d,
0.1301190331654587d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 36,
    Value = 
new System.Double[3]
{
0.5552437716731788d,
0.9019016747249066d,
0.17759293809685917d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 23,
    Value = 
new System.Double[3]
{
0.06734366974014849d,
0.22995807478555352d,
0.5430877353155474d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.9810086223523982d,
0.1886705817981379d,
0.42708892902914186d,
0.5035905269568899d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 39,
    Value = 
new System.Double[3]
{
0.3223832211317811d,
0.9029442012885462d,
0.5432429827996486d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.688344174471616d,
0.7084724844317271d,
0.008813169958374889d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 46,
    Value = 
new System.Double[4]
{
0.5106383358627383d,
0.9551342523720162d,
0.7091292009752207d,
0.025007971979235877d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 28,
    Value = 
new System.Double[4]
{
0.8243649088362771d,
0.459688219832053d,
0.6356191176562916d,
0.7126105343416239d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 51,
    Value = 
new System.Double[3]
{
0.1092344071755057d,
0.6054633795447302d,
0.025921186626146175d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.9748834906175506d,
0.37783691305454636d,
0.5218674976825086d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 57,
    Value = 
new System.Double[4]
{
0.9148774923922648d,
0.9417890868120821d,
0.8999476654531287d,
0.8258509125732993d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 34,
    Value = 
new System.Double[4]
{
0.2264050395929278d,
0.8233766243447683d,
0.4691212902896932d,
0.07498527451550785d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 61,
    Value = 
new System.Double[4]
{
0.371232847900834d,
0.3805482535204454d,
0.30264606602946087d,
0.5298780096968729d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 67,
    Value = 
new System.Double[4]
{
0.6089145857462331d,
0.3249176333357965d,
0.8703966172267215d,
0.5312150258057714d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 43,
    Value = 
new System.Double[4]
{
0.5781159645605395d,
0.2541586700182028d,
0.016789770112513147d,
0.2572829256826381d,
},
    NullableValue = 
new System.Double[3]
{
0.2198803946069553d,
0.4092818466524609d,
0.18686576255197096d,
},
},
    NullableValue = 
new System.Double[4]
{
0.5017548503461923d,
0.6072460646945735d,
0.0015526809915310524d,
0.18189374820205706d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 75,
    Value = 
new System.Double[3]
{
0.9162827898771068d,
0.59702185370244d,
0.09253095421135338d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.8626785147000691d,
0.4720610461085527d,
0.29733213085482924d,
0.3816328881496709d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 49,
    Value = 
new System.Double[3]
{
0.33578771964903986d,
0.2840407542734924d,
0.6875300054031575d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.09843441697386368d,
0.5973068769980223d,
0.3067957494494856d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 84,
    Value = 
new System.Double[4]
{
0.13872882925505892d,
0.6632169118447548d,
0.2547778572767787d,
0.6067837719791473d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 87,
    Value = 
new System.Double[3]
{
0.0957174028214921d,
0.3613395426661319d,
0.10443798787995406d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 51,
    Value = 
new System.Double[4]
{
0.979059024703847d,
0.9230300837891586d,
0.9372106597982864d,
0.24083496897842105d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 94,
    Value = 
new System.Double[4]
{
0.014969504914374099d,
0.09813050437088056d,
0.8821819942404785d,
0.08325702614502528d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 96,
    Value = 
new System.Double[4]
{
0.5803455980631035d,
0.031098047897468284d,
0.3085134413183992d,
0.18483202443584346d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 54,
    Value = 
new System.Double[4]
{
0.9255419131813655d,
0.43383546399735307d,
0.4582607430928072d,
0.5058337969643338d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.15405137567906924d,
0.23688951844700512d,
0.8299432800504719d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 102,
    Value = 
new System.Double[3]
{
0.740432714652517d,
0.20799443004916118d,
0.6867199805379464d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.5278335832377994d,
0.7144025746138224d,
0.41487873296109934d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 106,
    Value = 
new System.Double[4]
{
0.7626326907955036d,
0.7730921297738086d,
0.12266488252141361d,
0.5092419348271412d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 56,
    Value = 
new System.Double[4]
{
0.6366208032921864d,
0.31809853442230396d,
0.19639531166518598d,
0.7113912644462567d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.8773669223765727d,
0.15213261381706822d,
0.8874306580639874d,
0.4990251351189733d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 107,
    Value = 
new System.Double[4]
{
0.5443692902361141d,
0.9770018087259723d,
0.5096356598364432d,
0.10784683603619083d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 114,
    Value = 
new System.Double[3]
{
0.49281356841357893d,
0.4892225071066014d,
0.2796793239463803d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 61,
    Value = 
new System.Double[4]
{
0.2739125900515701d,
0.41878399880136286d,
0.24268611179469857d,
0.5221826437425546d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 116,
    Value = 
new System.Double[3]
{
0.7610358070174806d,
0.6998724642729823d,
0.13950486621159186d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 123,
    Value = 
new System.Double[3]
{
0.027230122542041046d,
0.7906554983143936d,
0.9943297553968d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 70,
    Value = 
new System.Double[4]
{
0.25882539267458915d,
0.2755367890341677d,
0.09460882641699564d,
0.1276260743799078d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.3318566284887935d,
0.426423958616033d,
0.49683657009625015d,
0.9969341228286104d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 127,
    Value = 
new System.Double[3]
{
0.3269094104861957d,
0.06962433352802733d,
0.7954837002210727d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 131,
    Value = 
new System.Double[4]
{
0.83916432567282d,
0.08781509147951849d,
0.8787039523287041d,
0.3403694831245332d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 78,
    Value = 
new System.Double[4]
{
0.932389089171234d,
0.26339701166161855d,
0.022587104387261303d,
0.7618638961291101d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.008784417433403413d,
0.936595065620415d,
0.5317643298991348d,
0.7917512406532927d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 138,
    Value = 
new System.Double[4]
{
0.7120983806038241d,
0.600056886535561d,
0.6580145634452346d,
0.48352613921090104d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.5743210193134173d,
0.6821843106457074d,
0.9286252374073893d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 140,
    Value = 
new System.Double[4]
{
0.6584204065792919d,
0.5279119230057124d,
0.498870872832587d,
0.6980911563736625d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 84,
    Value = 
new System.Double[3]
{
0.6168035824058146d,
0.621565907540669d,
0.8837746686292663d,
},
    NullableValue = 
new System.Double[4]
{
0.25204934724343286d,
0.9075605280876203d,
0.942478446599152d,
0.0774400561643539d,
},
},
    NullableValue = null,
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
0.5473118452450788d,
0.19181393841710692d,
0.09531754164315509d,
0.1301190331654587d,
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
new System.Double[4]
{
0.9810086223523982d,
0.1886705817981379d,
0.42708892902914186d,
0.5035905269568899d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.688344174471616d,
0.7084724844317271d,
0.008813169958374889d,
}));
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.9748834906175506d,
0.37783691305454636d,
0.5218674976825086d,
}));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[30], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[30], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 80, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[30], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 18, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 127, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[30], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 36, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 116, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 51, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[29], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 57, 13))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[29], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray1M>(15);

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
                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

