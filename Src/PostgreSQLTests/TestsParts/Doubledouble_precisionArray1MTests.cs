

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
0.9593635209611103d,
0.21940130018315152d,
0.381357399857142d,
0.18759575493552494d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8441829759405879d,
0.8681025071140798d,
0.1661007038419441d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 12,
    Value = 
new System.Double[3]
{
0.030617983558782202d,
0.395575051943838d,
0.7941092640068039d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 8,
    Value = 
new System.Double[3]
{
0.5468564696762893d,
0.6482254833551099d,
0.10338829150075113d,
},
    NullableValue = 
new System.Double[4]
{
0.020044658161990858d,
0.6777869914522197d,
0.05014183479855849d,
0.2981652168788703d,
},
},
    NullableValue = 
new System.Double[4]
{
0.03887698140141993d,
0.8860027144409555d,
0.9764835240645007d,
0.6525184495357861d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 21,
    Value = 
new System.Double[3]
{
0.9133556035328638d,
0.5797371569507906d,
0.4129457526046889d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.6773694307161371d,
0.5384806820424636d,
0.6456062633735359d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 22,
    Value = 
new System.Double[4]
{
0.7784610118384542d,
0.8973135377957282d,
0.15731165902008348d,
0.717126169579684d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 10,
    Value = 
new System.Double[4]
{
0.38685613391379203d,
0.001474479367448489d,
0.6273083582518453d,
0.19092161462569668d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 28,
    Value = 
new System.Double[4]
{
0.8644096576363736d,
0.24369454741151042d,
0.0023440487958429346d,
0.5438841966827181d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 31,
    Value = 
new System.Double[3]
{
0.18821221429118118d,
0.09612270138611179d,
0.3102241626888732d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 17,
    Value = 
new System.Double[4]
{
0.9157506480135413d,
0.040884861462825994d,
0.6134886834777418d,
0.48310743027063285d,
},
    NullableValue = 
new System.Double[3]
{
0.8144099963647817d,
0.9456510478241921d,
0.4877365556763774d,
},
},
    NullableValue = 
new System.Double[3]
{
0.38392833948230776d,
0.7004605116202548d,
0.1680858700783563d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 39,
    Value = 
new System.Double[3]
{
0.6956229046121458d,
0.5339178470745506d,
0.8637257639563001d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 40,
    Value = 
new System.Double[4]
{
0.5772222087487378d,
0.49788919423394906d,
0.7183753303550138d,
0.9537237461658509d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 23,
    Value = 
new System.Double[3]
{
0.6617014641770366d,
0.9142479760593456d,
0.8519080215631288d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.3300659846061228d,
0.9176198498323569d,
0.5160014518372052d,
0.07785852902911605d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 44,
    Value = 
new System.Double[3]
{
0.610435960472858d,
0.40733927212035326d,
0.5306818681002353d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8558383530568493d,
0.4495808392124524d,
0.12558379642126682d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 48,
    Value = 
new System.Double[3]
{
0.26236394553806386d,
0.759449044718185d,
0.6608579257277782d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 27,
    Value = 
new System.Double[4]
{
0.0007232360797314596d,
0.5375440203711923d,
0.38624444535753333d,
0.22011095066828712d,
},
    NullableValue = 
new System.Double[4]
{
0.4644901605309931d,
0.8166474899303207d,
0.4623656221813194d,
0.18692764588388322d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 53,
    Value = 
new System.Double[3]
{
0.880490747595598d,
0.23551152951800614d,
0.19291245535620094d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 59,
    Value = 
new System.Double[3]
{
0.7680250942932112d,
0.8965557640276757d,
0.8755155967264746d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 36,
    Value = 
new System.Double[3]
{
0.05794502156516912d,
0.3372876358032455d,
0.15574075950547472d,
},
    NullableValue = 
new System.Double[4]
{
0.6770291913035998d,
0.1464316055278928d,
0.7354280684218116d,
0.6194088982292237d,
},
},
    NullableValue = 
new System.Double[3]
{
0.6351434072530263d,
0.16673817861382112d,
0.15555108339645474d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 61,
    Value = 
new System.Double[4]
{
0.06510413666350379d,
0.9862558741313582d,
0.3381237652620521d,
0.8230801048163127d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.1813514897363674d,
0.03509538034514692d,
0.8220854568156417d,
0.07545140209447421d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 65,
    Value = 
new System.Double[4]
{
0.1811902556925774d,
0.2696222709597227d,
0.24049351830046461d,
0.6501463262304695d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 41,
    Value = 
new System.Double[3]
{
0.09408708868186366d,
0.8658955625228387d,
0.17276423511570993d,
},
    NullableValue = 
new System.Double[3]
{
0.7664067284968888d,
0.6731016260492102d,
0.16576037595962134d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 74,
    Value = 
new System.Double[3]
{
0.7063113375869313d,
0.6247724027568357d,
0.856283532252611d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 76,
    Value = 
new System.Double[4]
{
0.7253863160491665d,
0.13244629080213632d,
0.06783668600391324d,
0.8498587852394499d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 48,
    Value = 
new System.Double[3]
{
0.3945722362226324d,
0.7650214946832782d,
0.975913548786738d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.5966489224957044d,
0.6923367378754501d,
0.887486680798517d,
0.4312839829964742d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 81,
    Value = 
new System.Double[3]
{
0.26560166516354844d,
0.8350619397854123d,
0.2989104347177757d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.2778236364222353d,
0.45606308436489107d,
0.7201990273786602d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 86,
    Value = 
new System.Double[3]
{
0.6252717435717214d,
0.8102390874922277d,
0.31495339780251363d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 53,
    Value = 
new System.Double[3]
{
0.42739514262132916d,
0.22278173457231665d,
0.7571259906254029d,
},
    NullableValue = 
new System.Double[3]
{
0.9005228919032591d,
0.3791923427969214d,
0.9156678993961603d,
},
},
    NullableValue = 
new System.Double[3]
{
0.6823597339008834d,
0.013434528529563172d,
0.16115613236574822d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 92,
    Value = 
new System.Double[3]
{
0.3258052388747953d,
0.1452546629905589d,
0.17993009409246463d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 97,
    Value = 
new System.Double[4]
{
0.9950470164385283d,
0.36488107736615394d,
0.05261080735635293d,
0.608698233853499d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 57,
    Value = 
new System.Double[4]
{
0.6970695573241579d,
0.1857322263928196d,
0.7097741207865634d,
0.9351711121547767d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 100,
    Value = 
new System.Double[4]
{
0.45104570967689483d,
0.1863410966742901d,
0.9409007546572677d,
0.9788192050674497d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 106,
    Value = 
new System.Double[4]
{
0.023473815815128196d,
0.8183785649105714d,
0.6416999197125419d,
0.6279381821746057d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 66,
    Value = 
new System.Double[4]
{
0.6120561136528422d,
0.5320021339423114d,
0.21486797226866516d,
0.30086124648945534d,
},
    NullableValue = 
new System.Double[4]
{
0.07324743312603199d,
0.11677229047300941d,
0.7451603311656565d,
0.9417750812004405d,
},
},
    NullableValue = 
new System.Double[3]
{
0.7344199956550285d,
0.9282212376982966d,
0.2675648546510022d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 107,
    Value = 
new System.Double[4]
{
0.9330658050863666d,
0.8018743617858202d,
0.7814744165800025d,
0.2347101220687443d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 116,
    Value = 
new System.Double[4]
{
0.85869167179795d,
0.170054731016981d,
0.8751577565882983d,
0.02968920063813907d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 70,
    Value = 
new System.Double[4]
{
0.1586955042196243d,
0.7833921639352416d,
0.8585398945732576d,
0.1546013597166459d,
},
    NullableValue = 
new System.Double[3]
{
0.08606436990595367d,
0.655523477930284d,
0.28965619951698574d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 124,
    Value = 
new System.Double[3]
{
0.5003069518282348d,
0.27592537348373514d,
0.23479881334860642d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.2693942392037335d,
0.8079024708011566d,
0.29987271859778286d,
0.16880954779827095d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 133,
    Value = 
new System.Double[4]
{
0.5667346487795726d,
0.26955381332092876d,
0.7495773415463004d,
0.9350817720453403d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 72,
    Value = 
new System.Double[3]
{
0.5964409390721439d,
0.7853717882051388d,
0.9416704755470199d,
},
    NullableValue = 
new System.Double[3]
{
0.9186825450806952d,
0.06725820851763287d,
0.776204962185623d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 139,
    Value = 
new System.Double[4]
{
0.4923833154012013d,
0.23770429191415887d,
0.5381263158028421d,
0.9016217846656007d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 148,
    Value = 
new System.Double[4]
{
0.7305272432790468d,
0.9223241704562255d,
0.4497136337090528d,
0.0026003147961644046d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 74,
    Value = 
new System.Double[3]
{
0.6588975904152237d,
0.4815723653878189d,
0.3496716066617733d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.8626444199860567d,
0.6444642644694044d,
0.8615821788321453d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 150,
    Value = 
new System.Double[4]
{
0.925875085320012d,
0.5209595514526985d,
0.08237901368999967d,
0.9954176854583955d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.37934733011154864d,
0.4881766586702201d,
0.4896654709169814d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 157,
    Value = 
new System.Double[3]
{
0.6536183313025195d,
0.3330950826595719d,
0.49132932458898493d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 75,
    Value = 
new System.Double[3]
{
0.9840363027317369d,
0.6119423487244d,
0.9652714748524057d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 162,
    Value = 
new System.Double[3]
{
0.5614620856615825d,
0.3268510140803257d,
0.9513301271772759d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.32855917324390715d,
0.04985259475674175d,
0.8904101210662677d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 168,
    Value = 
new System.Double[4]
{
0.379403292797164d,
0.9978364481125221d,
0.5444820626506601d,
0.3863863223435883d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 78,
    Value = 
new System.Double[3]
{
0.5002077868859032d,
0.42211792178269736d,
0.30358819442535734d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 175,
    Value = 
new System.Double[3]
{
0.3358821347145745d,
0.9755518533803047d,
0.20010151436453694d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 183,
    Value = 
new System.Double[4]
{
0.19540628314095265d,
0.2717647775130332d,
0.28307143111719313d,
0.5332368339862541d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 83,
    Value = 
new System.Double[4]
{
0.017955461616968038d,
0.37316822765296087d,
0.8689714422037684d,
0.26757292832219104d,
},
    NullableValue = 
new System.Double[4]
{
0.538864714193321d,
0.09585493275891732d,
0.05064885696701116d,
0.13013840013792954d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 192,
    Value = 
new System.Double[4]
{
0.5988602921728656d,
0.4160765730271999d,
0.8354914943405751d,
0.4496386910067376d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.01921654081804569d,
0.4413066088769271d,
0.6247168116716564d,
},
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.38392833948230776d,
0.7004605116202548d,
0.1680858700783563d,
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.3300659846061228d,
0.9176198498323569d,
0.5160014518372052d,
0.07785852902911605d,
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
0.8558383530568493d,
0.4495808392124524d,
0.12558379642126682d,
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
0.6351434072530263d,
0.16673817861382112d,
0.15555108339645474d,
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
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 97, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 157, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 139, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 148, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 12, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[30],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[31],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 28, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 59, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 65, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 124, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 74, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[34], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[30], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[31], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[32], false);
                Doubledouble_precisionArray1M.AssertModel(models[19],_testData[33], false);
                Doubledouble_precisionArray1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[30], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[31], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[32], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[33], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[34], false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(Doubledouble_precisionArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI), typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                await ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

