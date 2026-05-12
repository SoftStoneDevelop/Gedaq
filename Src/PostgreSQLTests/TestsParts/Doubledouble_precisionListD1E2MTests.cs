

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
    internal partial interface IDoubleListdouble_precisionListD1
    {
    }
    
    internal partial class DoubleListdouble_precisionListD1 : IDoubleListdouble_precisionListD1
    {


#region TestData

        private readonly Doubledouble_precisionListD1E2M[] _testData = new Doubledouble_precisionListD1E2M[]
        {
            new Doubledouble_precisionListD1E2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3652538870226598d,

0.42145409763225816d,

0.15759723254438573d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.32603652744973877d,

0.17624591810359125d,

0.3082560676055174d,

0.5094664882922503d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7323211389526805d,

0.0023830771126803763d,

0.6812517398955165d,

0.32244064340994927d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08922139175932153d,

0.7943276026751978d,

0.2023056118431369d,

0.5389597102918249d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08604187196102309d,

0.3551306000422594d,

0.017889036092987642d,

0.34503246587807435d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.42508668057814225d,

0.033835363710651545d,

0.11426931829467601d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.533779801955547d,

0.35419722359366923d,

0.550216866053104d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.026184363701328484d,

0.14658961206547272d,

0.33627705471248015d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6185933531922363d,

0.82221368695953d,

0.25152613376893906d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9283186171695627d,

0.2638951908590812d,

0.7557838402379249d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2972685361811448d,

0.687389735257453d,

0.4792268469408434d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9992503489217429d,

0.1763494165932995d,

0.5179057646102374d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7548299870422288d,

0.23769810840730254d,

0.20019113770985808d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0008663086056266422d,

0.2746704069079434d,

0.7189644351208049d,

0.7046669811361133d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13362117847972832d,

0.8580349777324152d,

0.5008693967185646d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47579938851238823d,

0.39280466376500545d,

0.6673409468808756d,

0.03046979896937163d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5883605942829364d,

0.5676730638611284d,

0.463823914702009d,

0.11833851920513772d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.043056462603666246d,

0.11149173938995327d,

0.624258518191498d,

0.0810587388870837d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5352222782598268d,

0.46374873476898226d,

0.44048791473147486d,

0.2578809486042568d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05588256769871269d,

0.04957207620053683d,

0.6819952074266633d,

0.8034178391826126d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6215129987911765d,

0.051715343423566984d,

0.5534168498039659d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.35374622421746593d,

0.34891859875393094d,

0.3797701926901408d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08086198128833721d,

0.7325107516022725d,

0.31400339059116444d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.24698281704992664d,

0.614449168763966d,

0.6687331460789513d,

0.7463533858209602d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.827831121482705d,

0.23026122360042556d,

0.4258587206772271d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5286664137910118d,

0.22916194716588845d,

0.6438717057385609d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5067484295759286d,

0.4397485510445258d,

0.8669658260254891d,

0.9043199871089613d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.11255776198619971d,

0.29341851882931214d,

0.1929990772514517d,

0.13656344452832692d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.009910628055868176d,

0.4670642952198d,

0.16541895420694774d,

0.6773337494735052d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0909012033617621d,

0.1371723616433258d,

0.2815174132977062d,

0.4686379424084014d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7474009822510348d,

0.543592382955054d,

0.08960463164940857d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8548444656818944d,

0.09149843246520639d,

0.8770619345749582d,

0.27614476547811995d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8237892821600458d,

0.9555134433658025d,

0.7341904316629034d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.23064653267029878d,

0.031200451485923875d,

0.14645648211171847d,

0.6123396841218267d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4486125496178027d,

0.6776672483274921d,

0.09761813032544009d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7193023381519063d,

0.27452736964687685d,

0.14075678025721305d,

0.6088502754894901d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4158099438933993d,

0.20996202848060908d,

0.49231396436717745d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29986584353488666d,

0.4230173398787146d,

0.32239245463380717d,

0.15167830568715857d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.035287477264195566d,

0.2539548089391793d,

0.23617769340653194d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.35045617435083476d,

0.07001343959330897d,

0.9699430172849548d,

0.10552924529650165d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7616928776465489d,

0.026977525629971022d,

0.0052332837367559115d,

0.9195554348133114d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.17699291449468235d,

0.38313812697540495d,

0.4298862591522917d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6134590974799051d,

0.034615376627480265d,

0.5911352687455076d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700385603594323d,

0.6025235844551254d,

0.017972922743719755d,

0.4499171626192877d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5412501426657318d,

0.9545033628798594d,

0.34758444797851706d,

0.6761335813092841d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8586722390862842d,

0.8869120316283111d,

0.0596952570059619d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.45655285509589005d,

0.7168661986099758d,

0.5369769351649227d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3254751818739111d,

0.14155119275436812d,

0.06612036322706227d,

0.5710643676686078d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6373267998281176d,

0.3758556944035435d,

0.4232296126236128d,

0.23042830758032118d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7981160950115196d,

0.3784476686420648d,

0.9148009302870723d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1692944387747577d,

0.29406510150677634d,

0.7095381157777392d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2107997109266755d,

0.6556537525711758d,

0.7565927056092921d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.547861348400525d,

0.06794498726614784d,

0.9308959163303503d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.781717480730648d,

0.8824922972391956d,

0.6733848351916722d,

0.6200432700678419d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8918091367172148d,

0.4866931383073524d,

0.7663362290375095d,

0.1336610337794123d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.35845482535799655d,

0.34249831536740105d,

0.32115408216549723d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.24332562916064682d,

0.07806351280832491d,

0.3972263316410911d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07975492527524586d,

0.813468370231595d,

0.5164821839857205d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5935147590284086d,

0.7892644831148165d,

0.9414195149303087d,

0.4019882940400734d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6675999446868907d,

0.11001006226777443d,

0.19933185223316652d,

0.06481632108741464d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4215235819870984d,

0.7315920690224962d,

0.07647841371600328d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.22168899329935177d,

0.282795516124281d,

0.4649724995070107d,

0.4421691551828879d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.29386149873573475d,

0.5472710948761991d,

0.2893380992717959d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.06758646750575015d,

0.617430085980814d,

0.943442022317407d,

0.25761360855262583d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0928425558420869d,

0.9590001691402386d,

0.9801338658261618d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11843474107106233d,

0.0862259670957708d,

0.38139258322258907d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5468947571749702d,

0.5222650710483626d,

0.17947931340964862d,

0.7224331609073634d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3809431644643204d,

0.7742194005187275d,

0.7021776430913496d,

0.7712420610989495d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.29241882132825225d,

0.8327505590766363d,

0.44914028231670056d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.21628570153184856d,

0.07402784776963556d,

0.2757391204780463d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11237523903727176d,

0.5694041893720969d,

0.7004171441694861d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8587887606105638d,

0.19728015141159438d,

0.4741061194221463d,

0.18144350594143777d,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
INSERT INTO public.doubledouble_precisionlistd1e2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)), 
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
                methodParametrName: "doubledouble_precisionlistd1e2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
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
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                methodParametrName: "doubledouble_precisionlistd1e2mi_id", 
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
                List<Doubledouble_precisionListD1E2M> models = null;

                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionListD1E2M> models = null;

                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 46, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 14, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 11, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 138, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 89, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 89, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatch(connection, 133, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models = await ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[12], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[13], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[14], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[15], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[16], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[17], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[18], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[19], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[20], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[21], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[22], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[23], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MI),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionListD1E2M),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
FROM public.binary_doubledouble_precisionlistd1e2m m
LEFT JOIN public.binary_doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models =  ((IDoubleListdouble_precisionListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
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
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI), typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models1 = new List<Doubledouble_precisionListD1E2MI>();
                var models2 = new List<Doubledouble_precisionListD1E2MI>();
                await ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MI>();
                var models2 = new List<Doubledouble_precisionListD1E2MI>();
                ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

