

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.855006986925128d,

0.44642224163120303d,

0.5444795203709581d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6624499173761687d,

0.061165237316246346d,

0.9150207961485073d,

0.721127835619151d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2287475450129014d,

0.6923469966996523d,

0.24768272833601257d,

0.3312064889567312d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8913027639154448d,

0.47269332910714235d,

0.9450764773329328d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.25176026399943296d,

0.30973620500781196d,

0.8489383735913303d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7177393925933253d,

0.554788649292446d,

0.0739656003154292d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3165043208393399d,

0.399647964326482d,

0.4146069255019956d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07241428963843932d,

0.7758667307779925d,

0.46949594209462864d,

0.09614850462309465d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6125334192538782d,

0.8116898092102124d,

0.7292832073402746d,

0.14081027730233897d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.516759461370769d,

0.7003411777918247d,

0.3069866862045756d,

0.4130244112510437d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6742555766222033d,

0.07837461965111148d,

0.3785353963835987d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19285385135973077d,

0.5797637880050021d,

0.04635688790154058d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11276483896237754d,

0.06294967271335372d,

0.297740308284955d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9418323190925934d,

0.2319058631087798d,

0.7834305939809503d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5632105833269221d,

0.0077887721770072416d,

0.1783900081402202d,

0.4019867393709621d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.32909345409017177d,

0.9113448756678217d,

0.8738057937974205d,

0.2620729684127239d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2989101149111423d,

0.7536445636569793d,

0.018920562370413063d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7713025661655586d,

0.036841172119276844d,

0.8582621836522001d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9508764307806744d,

0.39595100935961514d,

0.6918268996662428d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.616258358143152d,

0.961854820755303d,

0.023921980721853586d,

0.7408083458711754d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3915909049288182d,

0.3461625458722274d,

0.9097856955623745d,

0.7451507557344775d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.383481630983207d,

0.8266327539865777d,

0.4590047749972297d,

0.5523859268801449d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40936129098772045d,

0.32043038686557623d,

0.8049099139542742d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5487482105346335d,

0.010120350224811725d,

0.6991056782980425d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08826448895500849d,

0.7006679409486882d,

0.04784729530429721d,

0.999464912956525d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5073482400215095d,

0.19210094348518836d,

0.5686651774408261d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8507519833630489d,

0.38850075547072893d,

0.605713436695927d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6664426515285592d,

0.1009298554507927d,

0.9892872755930292d,

0.7871740567817429d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28398379328112144d,

0.7783682606526994d,

0.547353155076614d,

0.5072833531561787d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6141300590052479d,

0.9050650829332944d,

0.5059665634165278d,

0.7144116828213907d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6812773173808695d,

0.5698827668957431d,

0.8829156297025311d,

0.4266122555743842d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.510172267017105d,

0.44621597062352136d,

0.6879926391429632d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.10482334746915856d,

0.8729434259320991d,

0.3766196220548239d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7820152284966371d,

0.3648000917266435d,

0.7538460042702714d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1918932863819245d,

0.41875155825115906d,

0.06888323969566001d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09723646310863943d,

0.953591893586526d,

0.21852341761678973d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5970254841534431d,

0.6062376779440396d,

0.9042421287092832d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40889218823599316d,

0.5151938204180393d,

0.4418224413197198d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7415088274086785d,

0.3893779335235469d,

0.024122634647120722d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.24906739814787837d,

0.9486064983880182d,

0.7968445926808856d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6085681465822651d,

0.33446604756750054d,

0.3675389869235548d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4909552962651813d,

0.3140563636248862d,

0.854249077247785d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.815011879215333d,

0.9739832530636532d,

0.037454357474586586d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7658674399350277d,

0.865270273859332d,

0.9661725143689025d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.72627055306608d,

0.6404270849553374d,

0.6443412681236766d,

0.00400391670408573d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4957688572322475d,

0.0003464153206237386d,

0.42120743075781686d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6659872336663735d,

0.23209944181349285d,

0.9684325810580948d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9784577951226421d,

0.07681238775550003d,

0.4006880221874042d,

0.3650756323686206d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.025462961720769894d,

0.926483717150103d,

0.44116432890443313d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4625344507755528d,

0.8619208041061807d,

0.1872971165744699d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9887082737116981d,

0.7037218505056086d,

0.4616495826508542d,

0.12919740683771586d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.54210268982386d,

0.13469736931192233d,

0.6151542309004508d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.48463379738527546d,

0.7846037073154767d,

0.8881736824076537d,

0.7623909348963424d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5059167715703137d,

0.3453504925418731d,

0.26558375617169083d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8758588414477417d,

0.8602239059679385d,

0.1678363130121231d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6677858159173614d,

0.11223613401757715d,

0.867526917585887d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6538464138978948d,

0.3281241498630477d,

0.2684240711066208d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4816836604149153d,

0.08831392934366966d,

0.8246736761384469d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6446998019449912d,

0.40822739879471825d,

0.39546469233461223d,

0.5470698338260008d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.899645163210626d,

0.24874240982238227d,

0.004842916612934234d,

0.6645023518332407d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9383023481505535d,

0.8437059135794542d,

0.09284673338680982d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4476908510918164d,

0.19179806593303617d,

0.00755624941179156d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9908102446106618d,

0.1264734443842782d,

0.2792383720493755d,

0.6003735471467566d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13306517096969406d,

0.07984384901410047d,

0.36828603681451655d,

0.7920658887091477d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7504898425646842d,

0.33264175318376354d,

0.5108825153461695d,

0.1405933809679154d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.03818268314807316d,

0.8908048715277065d,

0.4262983013709397d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6564064426929168d,

0.28694190798906116d,

0.017127956310243664d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6300531749294607d,

0.7381129951109908d,

0.07444068194494236d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.10326244102740767d,

0.663853197760384d,

0.44562964191940835d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20872882338595466d,

0.6721494397929871d,

0.643051368203131d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16020004922976006d,

0.8393453472201272d,

0.7539618040592062d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7788229058404487d,

0.29609481076662747d,

0.11678740804087673d,

0.6727465611008641d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.378595987564176d,

0.1236629892421397d,

0.13199870366200284d,

0.6476621335625896d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9915109718896934d,

0.5499627916128141d,

0.7779868533693126d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.45766454945359325d,

0.8160952679114041d,

0.5407707524718918d,

0.8861005408031444d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.756217095382608d,

0.6843081629918887d,

0.5134240883332736d,

0.13858839790009914d,

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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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

                    if(resultIndex == 2)
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 109, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 130, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 121, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 121, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 2, query1, 76, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 150, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 85, 60))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[34], false);
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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[30], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[31], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[32], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[33], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 158);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[31], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[32], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[33], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[34], false);
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

