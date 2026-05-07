

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
0.20964344361025766d,

0.35316533781761816d,

0.4450745527426644d,

0.5084736683154277d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.06859824255545521d,

0.8022449513804663d,

0.8500047958474671d,

0.475691842989459d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6807061542851711d,

0.602149658128283d,

0.004084010748618971d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.23194078316832367d,

0.2697458216708679d,

0.5067435110379822d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5451648889175844d,

0.15592766775881617d,

0.044870304296040775d,

0.7117023102523832d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5935223912891947d,

0.9516011402154468d,

0.45359562372029205d,

0.8724662785427821d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6100895793403467d,

0.23155451384041337d,

0.16862799650999494d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.23936263894372023d,

0.4604282887814416d,

0.20731107169676766d,

0.9685914849170247d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3463067389941924d,

0.7305362031710557d,

0.8990813595815225d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7555998894348513d,

0.47678461212429546d,

0.057175036147049885d,

0.7659714485377764d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1779460888591512d,

0.4805934428222648d,

0.9310856163287652d,

0.6862938811408662d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7349642881733794d,

0.5315102765957018d,

0.8433441439854324d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7525172076358785d,

0.8753642545612127d,

0.4786224339371261d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26452633094106737d,

0.5685374761338758d,

0.2447010096490101d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2342099098862751d,

0.8576265328930404d,

0.9315977745372038d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5442734957606248d,

0.7018153565384779d,

0.7822484758040024d,

0.8314123603373749d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9523022973607066d,

0.49472451741489376d,

0.880196393377001d,

0.5242408760333138d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4638698022943918d,

0.6015199927755611d,

0.2497063093256492d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6568266462728652d,

0.10124884747193263d,

0.4079336223924144d,

0.05428272211712537d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9935109628565516d,

0.35001228183297173d,

0.4787791724284306d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7316880486633313d,

0.8509435365303665d,

0.6898399168504991d,

0.22268886356985018d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19695736591446833d,

0.6180787412937225d,

0.20936492171117205d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8288431125759866d,

0.7666122429860079d,

0.21812220993001652d,

0.41278319796236906d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1347063538525115d,

0.527313575947707d,

0.06626980872871047d,

0.10747478530102672d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4148606625042588d,

0.011800723699921911d,

0.23862623452229204d,

0.4559446241485905d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13345753833991658d,

0.7283378438196724d,

0.8154209443097343d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05535615544825445d,

0.24669970763541849d,

0.03332941715039772d,

0.039949624538953454d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.42573416546079856d,

0.27276431228134634d,

0.3131523399818905d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2956041436271494d,

0.8152423138293672d,

0.2831433670943103d,

0.2027058898294566d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9959059202480036d,

0.48357825057707504d,

0.399606765143414d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8279970080345547d,

0.4962233261926957d,

0.6412027247530956d,

0.7588620974759201d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7868203759478174d,

0.8261550273703662d,

0.4960840629466281d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7379413930054837d,

0.5621480646549603d,

0.5230887071699329d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8328386938297493d,

0.06025817344172235d,

0.915999188379364d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4388927109446482d,

0.7840929677308d,

0.5844761270545349d,

0.9205515167839537d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.913820289121651d,

0.7958696633427812d,

0.9084861100779682d,

0.2813106965227218d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20984480156335228d,

0.8638883409857845d,

0.01719270477892676d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.47113829784298444d,

0.8305209244656397d,

0.6180080227850168d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.37427764057941415d,

0.4605824648903828d,

0.4566943209053508d,

0.3848576334573399d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8896413110335053d,

0.8340459223917466d,

0.3894347893472566d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.34868431592426863d,

0.39158798012666884d,

0.9825662333253009d,

0.04859263039802353d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.35887179962255555d,

0.9612185875582193d,

0.9582484125651365d,

0.9306970695398775d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9480178345216764d,

0.35741251482915803d,

0.514458036625536d,

0.5609443946834833d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8130889027020132d,

0.7786555603426426d,

0.13185760578143624d,

0.957359137339058d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2867557443171229d,

0.2682876589551946d,

0.6501130582755406d,

0.6792474355541375d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6151698711438831d,

0.48116779272858057d,

0.8556313504730858d,

0.051108247894349756d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.014098118519414227d,

0.6380665033238909d,

0.5310254761726031d,

0.9160475699982272d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9490581287785173d,

0.46672463758186455d,

0.43900784783097735d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7265671314391347d,

0.044455647717123736d,

0.5576576148933639d,

0.8190649355961737d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7511429557168929d,

0.22225396845676815d,

0.5252470532773044d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.23785879148346623d,

0.17934895814918383d,

0.475733451181906d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.36645667339337484d,

0.33286571646785645d,

0.23218477047303565d,

0.08927629707170093d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.539214777482348d,

0.4095169000418999d,

0.9547348249518982d,

0.40841348339785377d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6047796203057064d,

0.802723973390328d,

0.6484400923556154d,

0.6793122560055327d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05245615546589366d,

0.622173813364343d,

0.8382606211056022d,

0.9000812843858373d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8882059646829096d,

0.0880870613500302d,

0.0854705117048814d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.34496383537066855d,

0.7762287665265867d,

0.7900752076399506d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.725050534408523d,

0.6144463333601572d,

0.5412357628033647d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8168479270447104d,

0.8872903223690932d,

0.5173039435042078d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.647758717631273d,

0.6355367908824169d,

0.582545582621912d,

0.5003760395234284d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2287148196270784d,

0.20618429933755178d,

0.028378187907408536d,

0.4223915547083722d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39736493959309527d,

0.8966922132916402d,

0.8570934952264029d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.817525805377448d,

0.7069036796405292d,

0.471142525044732d,

0.9497868344732904d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3761126393557995d,

0.7638590837013138d,

0.5786345330186654d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.46654761695142355d,

0.7060365328729713d,

0.2481039531186261d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13235454018329196d,

0.9761934775765732d,

0.6302864945981198d,

0.7903384572094359d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4724455454458374d,

0.36891842685830334d,

0.48441749717190785d,

0.17474575348506338d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6096818854222638d,

0.18093343290563346d,

0.8294656261676838d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.24358288638098802d,

0.6245339480274469d,

0.9146956124087866d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5647257427701715d,

0.7514990598421047d,

0.25003461962881735d,

0.9811522280593573d,

},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 144;
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 75;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 75, query1, 168, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 168, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 138, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 164, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 161, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 168, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[34], false);
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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[14], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[21],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[22],_testData[29], false);
                Doubledouble_precisionArray2M.AssertModel(models[23],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[24],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[25],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[26],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 143);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
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

                await ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
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

                ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI), typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray2MI>();
                var models2 = new List<Doubledouble_precisionArray2MI>();
                await ((IDoubleListdouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MI>();
                var models2 = new List<Doubledouble_precisionArray2MI>();
                ((IDoubleListdouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

