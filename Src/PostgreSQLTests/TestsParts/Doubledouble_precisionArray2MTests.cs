

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.035898366538667736d,

0.9587757364168642d,

0.925256580199703d,

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
0.9020939017031258d,

0.7708821462973182d,

0.5872867589081457d,

0.33346372321390194d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8058006267690563d,

0.7852501100884568d,

0.2723659358713948d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.34322617844245207d,

0.3849770153298733d,

0.5241533369372161d,

0.5049301049903528d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9947575350165804d,

0.6573555317422968d,

0.4853455029458449d,

0.9703850192523024d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.21372073577350081d,

0.8175872803019298d,

0.6404572609334498d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.859836896697788d,

0.17763778493258753d,

0.22151173251182132d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.22248711754000472d,

0.3259573315673282d,

0.8686284749117656d,

0.7026358056274816d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7391706431349643d,

0.7493328667090414d,

0.07813817780169707d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8897347958042254d,

0.20699953768561852d,

0.9081974650580554d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3628588759751229d,

0.37783070871615965d,

0.7898882094574192d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40062762756190307d,

0.948161096062436d,

0.14083921191040827d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.00728877805060224d,

0.09945960588745884d,

0.02278580098820482d,

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
0.43373076857292203d,

0.6200427469477956d,

0.19750495672614765d,

0.8690274754942953d,

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
0.9842585144072131d,

0.30657604818798967d,

0.5686082247695793d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.02987093765405968d,

0.296860978547797d,

0.6001541467350568d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.514689986402058d,

0.8769914044098284d,

0.950351409664055d,

0.9930727660505668d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5842634134974616d,

0.6985493277800989d,

0.8934388338175849d,

0.18347296693047022d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5835999951927563d,

0.19951417932016924d,

0.051268173327134514d,

0.9205508215649028d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.15250877318873246d,

0.3140042054078185d,

0.05339547650913856d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6149847149132182d,

0.3951558999399878d,

0.7996095292040571d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.028306992621681237d,

0.4958296335295831d,

0.39371657592605414d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8321861053398175d,

0.5360431515832534d,

0.8914512137039999d,

0.6635046905430834d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.15491042250101605d,

0.9060254458119397d,

0.5939724716875574d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0008098012968099644d,

0.33694585846108926d,

0.8117881164319305d,

0.1097053463045673d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8751816257661779d,

0.7278837810004893d,

0.46562394966835585d,

0.9544935955574879d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9337257789251598d,

0.07145363490817414d,

0.005451712853581259d,

0.710682818281874d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7405780211772195d,

0.9606828067444927d,

0.28216329166410015d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6309907752168706d,

0.7804965346941666d,

0.09763679060516184d,

0.3637567555302522d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.25233073157414865d,

0.17416964393346068d,

0.27165945900621347d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28588759278143416d,

0.10178776805426726d,

0.2900935073842733d,

0.9392834697997073d,

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
0.35798139645587024d,

0.20654894497008414d,

0.016650341482373765d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7068498196091788d,

0.4400701148431463d,

0.7586413703793377d,

0.2721491630655213d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.833002001385421d,

0.9217448307113554d,

0.5647764097108148d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.045882506518917565d,

0.480569922453974d,

0.2612055012402472d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6664533360055223d,

0.2975450622016408d,

0.6079465397296412d,

0.8409585734844182d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7923167056717353d,

0.9086095071024031d,

0.8321351679571753d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07808965358238618d,

0.22088280019038165d,

0.41282284350584764d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3311839116570414d,

0.9103700237059648d,

0.07709145351186175d,

0.5890800860209147d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4099190947556265d,

0.756345447454107d,

0.48142122679537336d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6756978207743551d,

0.829557241844776d,

0.818173060749945d,

0.1008146174497746d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6267916510730959d,

0.4826683314328155d,

0.13131991741565463d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18094646509313805d,

0.8208646118571d,

0.8350328760629805d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4756942303266689d,

0.05440198291976628d,

0.10021276339208185d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13214867036127975d,

0.40283348404126196d,

0.5947362945875292d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9114134086672365d,

0.8277142205336936d,

0.6290015952979983d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5104971251274206d,

0.8589705702786421d,

0.23069316079602797d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.954529836032909d,

0.5593985681813946d,

0.9808554271430089d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5640895717052883d,

0.5633571522673487d,

0.2620648861235113d,

0.5000930777381869d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6721321311662597d,

0.11765620433372381d,

0.6069158219403544d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.015125671125181817d,

0.21984996967771897d,

0.7190669135055552d,

0.6322309338258397d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.888845994597422d,

0.5015533668732184d,

0.5699473748799048d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4125645493363491d,

0.48152431833248377d,

0.7962519780932394d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6822564300723495d,

0.27304302141139436d,

0.4718394064546876d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5377162309552269d,

0.6942640935160228d,

0.20269767588943777d,

0.174844715795213d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8627853373702532d,

0.06759911695325971d,

0.11569838225879803d,

0.49717281177041484d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9931446324619005d,

0.7200390452808382d,

0.30504446470769d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8301503445761339d,

0.02489934954325268d,

0.5674195811875299d,

0.5620581742528937d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5991893496112886d,

0.9506832616596651d,

0.9124415970660287d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7102965645055336d,

0.4504114165974402d,

0.14297930939636438d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8383005857792393d,

0.085408643961565d,

0.11140223742688138d,

0.5883596634476967d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7525419383296645d,

0.6327658714016828d,

0.2634683820098018d,

0.4336363526840684d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1908157865206458d,

0.6863238063492068d,

0.6728961919550825d,

0.7766598907422084d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6765783659367457d,

0.7886919279276877d,

0.48156616862920665d,

0.1617488956169898d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6019217679732977d,

0.5285708433384515d,

0.6590990517823433d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12054291657592198d,

0.590864972641938d,

0.4581628421527314d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21134653387159485d,

0.1828110485741905d,

0.09306966579482212d,

0.3775668420100394d,

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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[29], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                parametr1.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 104, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[29], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 28, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 104, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 138, query1, 93, query2))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 66, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 138, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 66, 9))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
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
        public  void DynQueryImportModelInnerTest()
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 8; i < 12; i++)
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 12; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
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

