

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9642607051604327d,

0.5941073417459485d,

0.43364842761423217d,

0.5491294694328999d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8705382919870505d,

0.09740002213771248d,

0.6638640583063344d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9965980084460428d,

0.6703477032455043d,

0.3316622415711956d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18141989527431313d,

0.25547185641833137d,

0.4635404084278062d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2875729123227124d,

0.19914551269419956d,

0.8323308119648192d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8468189197552773d,

0.8101866583873492d,

0.9761384845679608d,

0.26930660348703683d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.24391145005503545d,

0.053451715418429635d,

0.6713633707905227d,

0.7494418661140925d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.015837737074600455d,

0.6958473649607417d,

0.06546156976574247d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7228532555401068d,

0.7799738171122906d,

0.30768054537261136d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6556589812148256d,

0.06148554396448258d,

0.9229717983446647d,

0.5192467480786658d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5432950668407976d,

0.22580548291096647d,

0.450272253299973d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31797054118861634d,

0.6763356226667055d,

0.9882525456763853d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3717227712688125d,

0.8563380133717674d,

0.3014012211586291d,

0.5348485305423152d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.35470297026307085d,

0.8302342830772307d,

0.3818753288314798d,

0.6442230402955708d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2932699206494397d,

0.6533954557492477d,

0.10819467610535527d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8587771534790228d,

0.6429777937480494d,

0.5948496801842377d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3244082834767159d,

0.4417946503876258d,

0.8952412201270877d,

0.6296763602072188d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8021138161631445d,

0.748616709889633d,

0.6722301888912515d,

0.5367699462043821d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.009445328670662834d,

0.47170259355960387d,

0.7165250159831279d,

0.46085446181242773d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6794984864254995d,

0.5503544385556675d,

0.0851043405384776d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4852831304119297d,

0.6838626445428427d,

0.5647880499771091d,

0.4805926455740842d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6700154438885457d,

0.4993848009137043d,

0.7486632367074458d,

0.9899882911950513d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.856205120199597d,

0.3081891519400345d,

0.8766956247870165d,

0.9357595443279625d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9847697466271569d,

0.42469539838131654d,

0.1082403332902595d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7309910963954204d,

0.02295301135887462d,

0.26801543048970733d,

0.6712262465615326d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7138631760953346d,

0.9632197020027908d,

0.23849368157330397d,

0.4261268491565844d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07640864867937325d,

0.994180941031856d,

0.3408233107607582d,

0.14555147973675842d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.843440944245177d,

0.05744883614048313d,

0.6640689130956813d,

0.40238387814800547d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.303743726983574d,

0.655337549810747d,

0.7809158961104887d,

0.45055690273966675d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.14470797878176922d,

0.024308009585209622d,

0.47084807078707325d,

0.8169281446197141d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8094178828921701d,

0.845937576250451d,

0.45918489728853185d,

0.19187405929485613d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33527347642302363d,

0.4202497056430001d,

0.6755429038482829d,

0.7045460094726335d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6979145394306809d,

0.9019239181047999d,

0.2932299320978733d,

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
0.37325109627464925d,

0.18093607457087224d,

0.1276647179513023d,

0.7215444631849143d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1953401644091075d,

0.9356666227194467d,

0.6313671026419782d,

0.38400507646224424d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.49476554504962844d,

0.5685584061848671d,

0.9551209937970999d,

0.19752838626768077d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3301066121713644d,

0.5155227668127362d,

0.6826373976099013d,

0.48598150203669865d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4453567663081085d,

0.0483294871679264d,

0.5282323799258745d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9541342443873979d,

0.9361480646538582d,

0.12855371441674435d,

0.39894355412639537d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8436621680362809d,

0.3809718514013203d,

0.22817529916724932d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.35390121299074395d,

0.8953097484342204d,

0.540885577280021d,

0.13300183531997667d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.39388540531351457d,

0.07385115424079702d,

0.891481014331975d,

0.17666578966447988d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8941545580464957d,

0.9149982391135075d,

0.3385483765629175d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5006024051462054d,

0.12823109683781964d,

0.4671718888169033d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2657271890605817d,

0.6183407160950508d,

0.9527895562798213d,

0.262626326586033d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9481433576419219d,

0.9470618144022498d,

0.573835663726822d,

0.15684814643671274d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5346942591150865d,

0.025616536085177333d,

0.16702977610202807d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3724624906624031d,

0.7230041675994915d,

0.9321804649464903d,

0.5769633524085193d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.42338059258166083d,

0.7183977149296477d,

0.6620185209082613d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3229820547019191d,

0.6946200302888565d,

0.643083145045797d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6172561245854503d,

0.8124176153776927d,

0.9617661472035923d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3611910534215935d,

0.3381541298777957d,

0.002939857217080566d,

0.7279513472802162d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6796677759631651d,

0.2696566350587192d,

0.2070441140096556d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07635643105072598d,

0.7624285341572039d,

0.6624687781090616d,

0.09045489323529743d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2551028140397298d,

0.43755011788710796d,

0.6195839670109673d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8082497009785305d,

0.36230846969716046d,

0.8106746051830164d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8877867086245396d,

0.4254030975821761d,

0.23687452328593117d,

0.754540340464025d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.590806246352841d,

0.8449824739528705d,

0.3905443329351854d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8967943234236955d,

0.5574338147833464d,

0.673648302937323d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.27500264208097136d,

0.6593703711877762d,

0.500822725317191d,

0.7794110089101858d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.01488887482547352d,

0.28270975117561525d,

0.15861557349572075d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0020633302201324977d,

0.15305128682598657d,

0.6721309920405593d,

0.035113619628764914d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7055324888220358d,

0.5793346451653875d,

0.45992569804289096d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4825613880844354d,

0.4300775555737053d,

0.013187609690115898d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.48839847168790573d,

0.3046505123807852d,

0.5712507591801318d,

0.7636307174584973d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8085200131318214d,

0.00542879768195248d,

0.4215004810523716d,

0.3028916114182587d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.44408982930680874d,

0.09546281604648954d,

0.6927383186343791d,

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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.doubledouble_precisionarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
                parametr2.Value = 70;
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
FROM public.doubledouble_precisionarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 79;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 103, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 6, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 62, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 135, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 62, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 25, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 55, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 88, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 117, 127))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[29], false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(Doubledouble_precisionArray2MI),
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

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(Doubledouble_precisionArray2M),
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

