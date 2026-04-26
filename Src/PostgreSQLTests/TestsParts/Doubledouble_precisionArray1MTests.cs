

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
    Id = 3,
    Value = 
new System.Double[4]
{
0.032495912769861746d,
0.7437458308400244d,
0.5684306800631274d,
0.7207577549626706d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.7080580862138929d,
0.7476303675215643d,
0.5431986548717709d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 9,
    Value = 
new System.Double[3]
{
0.4011779234022991d,
0.44126688442733997d,
0.46779443170931223d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 2,
    Value = 
new System.Double[4]
{
0.8650921356471866d,
0.2732348261100386d,
0.39783100406556826d,
0.7494289833594211d,
},
    NullableValue = 
new System.Double[4]
{
0.010440140310812751d,
0.9570041852809982d,
0.5703038616310353d,
0.24782543930801582d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 14,
    Value = 
new System.Double[4]
{
0.6262582923073753d,
0.021572243009575942d,
0.43704922546311564d,
0.6748479583676336d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7638517557585853d,
0.8459808330742086d,
0.7448716280292316d,
0.3588916555689967d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 15,
    Value = 
new System.Double[3]
{
0.14774025037741856d,
0.4655185472054002d,
0.6408575463885451d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 5,
    Value = 
new System.Double[3]
{
0.8589592513926506d,
0.7959531280179414d,
0.15822539161485183d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 22,
    Value = 
new System.Double[4]
{
0.0813039288884303d,
0.3569289063417813d,
0.11258465285168917d,
0.2255162333180617d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 29,
    Value = 
new System.Double[3]
{
0.2265900078266705d,
0.04261625451913975d,
0.8176770368525796d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 6,
    Value = 
new System.Double[3]
{
0.3034822861713773d,
0.17624705476231473d,
0.8945296646747181d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.4353077195571776d,
0.2142955664947026d,
0.1447357092355196d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.18682689094963334d,
0.5413079948045724d,
0.6459026623889362d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 40,
    Value = 
new System.Double[3]
{
0.022529248441074068d,
0.37022103620078595d,
0.648814332638457d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 7,
    Value = 
new System.Double[4]
{
0.5495132144872588d,
0.1500677139616522d,
0.4666881068026565d,
0.5534157640380508d,
},
    NullableValue = 
new System.Double[4]
{
0.3522311057737617d,
0.09900136621813449d,
0.165241032284983d,
0.4121902306663978d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 48,
    Value = 
new System.Double[4]
{
0.16449784866808448d,
0.02637742516489483d,
0.6300574847024882d,
0.19504347435415925d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.5214864026044232d,
0.13527658543798404d,
0.11529012788830817d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 56,
    Value = 
new System.Double[3]
{
0.9354628248808086d,
0.005066656379626222d,
0.8311258743660618d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 9,
    Value = 
new System.Double[3]
{
0.8035935727019756d,
0.6476161160179698d,
0.45456774180516135d,
},
    NullableValue = 
new System.Double[4]
{
0.19245897116841648d,
0.06802904716378333d,
0.756254466667661d,
0.35930802258792227d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 61,
    Value = 
new System.Double[4]
{
0.6031048676667492d,
0.6852521322039488d,
0.23556835803966658d,
0.29732581199153474d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 62,
    Value = 
new System.Double[3]
{
0.028529562392404118d,
0.2519234996956816d,
0.7911868014425079d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 15,
    Value = 
new System.Double[4]
{
0.584687524706079d,
0.9311750942169797d,
0.8371431461699128d,
0.09294148766911192d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.234666433858722d,
0.4815163630650333d,
0.33759211564562297d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 70,
    Value = 
new System.Double[3]
{
0.03799059738319743d,
0.8531566142849364d,
0.689059720123003d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.44574609724010594d,
0.7359901002160081d,
0.9969077072184545d,
0.2245714825005185d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 79,
    Value = 
new System.Double[3]
{
0.7654522066893075d,
0.6404192634862097d,
0.6455623741999644d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 21,
    Value = 
new System.Double[4]
{
0.7537094219055785d,
0.5609938170426804d,
0.5224990011437955d,
0.2792156421280717d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.5067631269438796d,
0.2848858597282641d,
0.8837983997502916d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 82,
    Value = 
new System.Double[4]
{
0.3367283677392984d,
0.3670144310661355d,
0.920324678891223d,
0.003455350052621542d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 85,
    Value = 
new System.Double[4]
{
0.3316683932346677d,
0.8063833645174255d,
0.8780164008467869d,
0.35486471967544386d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 30,
    Value = 
new System.Double[4]
{
0.42001361208667454d,
0.9539004510437329d,
0.6356565019249235d,
0.3869895216560937d,
},
    NullableValue = 
new System.Double[4]
{
0.2852951407381584d,
0.02188256972140845d,
0.8935574349490879d,
0.2730817928726288d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 87,
    Value = 
new System.Double[3]
{
0.1753439779698419d,
0.16173104955503914d,
0.5712978748006264d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 94,
    Value = 
new System.Double[3]
{
0.3392222314551284d,
0.8592278264976977d,
0.04959380845660044d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 34,
    Value = 
new System.Double[4]
{
0.6006572172452598d,
0.11048109022586361d,
0.031109937069187188d,
0.5915404185472974d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.35007906391212795d,
0.7276676119822626d,
0.5028694939692937d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 97,
    Value = 
new System.Double[4]
{
0.6460118583413901d,
0.7512621725977652d,
0.8981860149312523d,
0.7132900116878963d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.6677909612371093d,
0.19009291975885645d,
0.04806968500484432d,
0.03404892318129249d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 102,
    Value = 
new System.Double[3]
{
0.878229866870525d,
0.9613635645018291d,
0.7179765736681841d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 37,
    Value = 
new System.Double[3]
{
0.7158493732856275d,
0.811133442872967d,
0.3447563364991524d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.2703189885921289d,
0.2744573373019431d,
0.4863554448512648d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 105,
    Value = 
new System.Double[4]
{
0.2044129098759213d,
0.9902578737325964d,
0.4346983336189555d,
0.4864410490337784d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 106,
    Value = 
new System.Double[3]
{
0.6680277725711167d,
0.20234466965650189d,
0.5622614913297569d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 41,
    Value = 
new System.Double[3]
{
0.1555685312832944d,
0.16710366623625572d,
0.7279351903394552d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.23008793789233917d,
0.7721837621080128d,
0.41229846792150693d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 109,
    Value = 
new System.Double[3]
{
0.8449680725501546d,
0.32777579824012293d,
0.5619850456789819d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 115,
    Value = 
new System.Double[4]
{
0.3412704930410687d,
0.6739128739967286d,
0.7875630410746279d,
0.4911213156396327d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 44,
    Value = 
new System.Double[3]
{
0.4140901245827634d,
0.09208922276147746d,
0.268174934260321d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 119,
    Value = 
new System.Double[3]
{
0.4860410904511433d,
0.03535559927407694d,
0.23185615152414285d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 124,
    Value = 
new System.Double[4]
{
0.752396562044251d,
0.460572017707367d,
0.7973772612116676d,
0.021682196678239674d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 51,
    Value = 
new System.Double[3]
{
0.12062474427923753d,
0.6924166105631264d,
0.8795046745068651d,
},
    NullableValue = 
new System.Double[4]
{
0.1032307251477923d,
0.6268129937575648d,
0.9042752477783508d,
0.2298664642190147d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8900812573841773d,
0.36966347782936004d,
0.19483337812064305d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 126,
    Value = 
new System.Double[3]
{
0.56703744150024d,
0.5771174204643916d,
0.7807749753918809d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.09235528268745108d,
0.7644274121560457d,
0.6353199202863578d,
0.12518205954583783d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 127,
    Value = 
new System.Double[3]
{
0.2902531414202999d,
0.28934897730416664d,
0.7858126383106494d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 59,
    Value = 
new System.Double[3]
{
0.7341193227943966d,
0.620472060432564d,
0.10429349741134941d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 130,
    Value = 
new System.Double[4]
{
0.2725267088478043d,
0.10661835735405845d,
0.5822452305812641d,
0.5041954407209494d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 134,
    Value = 
new System.Double[4]
{
0.30502220990277396d,
0.9046711730385231d,
0.28382049247150665d,
0.2756719901539094d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 66,
    Value = 
new System.Double[4]
{
0.4536897198308595d,
0.23487538992943402d,
0.776624217818925d,
0.007077107333054999d,
},
    NullableValue = 
new System.Double[3]
{
0.7698532385964133d,
0.15630199434100334d,
0.2323319484117332d,
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
new System.Double[3]
{
0.18682689094963334d,
0.5413079948045724d,
0.6459026623889362d,
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
                Assert.That(nullable, Is.Null);
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
0.5214864026044232d,
0.13527658543798404d,
0.11529012788830817d,
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.234666433858722d,
0.4815163630650333d,
0.33759211564562297d,
}));
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[5], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[6], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[7], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[8], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[2], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[3], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[4], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[5], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[6], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[7], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[8], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[29], false);
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

                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[5], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[6], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[23],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 29, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelBatchAsync(connection, 29, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
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
                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelBatch(connection, 85, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
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

