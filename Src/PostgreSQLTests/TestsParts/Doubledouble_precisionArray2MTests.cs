

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
new System.Collections.Generic.List<System.Double>(4)
{
0.5226764385588598d,

0.9822173048176264d,

0.8001858155368301d,

0.6137885217488757d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3942124660907307d,

0.9737327026938898d,

0.28687353630819656d,

0.04655046202950697d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7981744561518448d,

0.9572244838662982d,

0.588184949537483d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0979571277622987d,

0.5471811504290958d,

0.705236903685359d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3697062578732824d,

0.1869715264323326d,

0.5679664120190433d,

0.6174539624244673d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.04524837801768533d,

0.6496318175441536d,

0.39188844666911016d,

0.3388174110615717d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0735591492629658d,

0.7053381792232002d,

0.9407214277991459d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.23122789618859552d,

0.9188703148716998d,

0.4726074341689812d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9133208988637802d,

0.10734806039711597d,

0.6262851832545859d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6810698120471087d,

0.2902196938476449d,

0.49133831485606927d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7855924070525474d,

0.10239333619532465d,

0.516598212116252d,

0.7395752206090704d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9680936259848455d,

0.6166179156464668d,

0.26149481450002743d,

0.2373519953224772d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8979386351969125d,

0.4398830915499855d,

0.24215219679241384d,

0.7424113284270115d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26249545655092843d,

0.9401204258069212d,

0.1895094429355656d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.74376100749104d,

0.34481541693760454d,

0.9918488829515322d,

0.8283206765063124d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2590568091621769d,

0.5193633374732824d,

0.15185661201584766d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7115567319362284d,

0.1614874143691103d,

0.614397824788152d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9156516841694816d,

0.4434983346609611d,

0.67720929753549d,

0.7971511054981002d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07667973858887567d,

0.6936279329243848d,

0.6895411272175448d,

0.995085963237123d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8082617933119682d,

0.8250478419799825d,

0.10298404723801702d,

0.3192102616132526d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2801271752828226d,

0.7806536597574776d,

0.1544979810065361d,

0.9932498970707645d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4645160750816446d,

0.9269064433899747d,

0.6632168171397922d,

0.545011860599211d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6509226527093772d,

0.20938775069178184d,

0.4638918102285806d,

0.3160869919653133d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2610089978406278d,

0.2664848835045929d,

0.7519651404032758d,

0.31363435985326094d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6122915147598785d,

0.05924408112707691d,

0.44788381709651015d,

0.17804668103438048d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12604324844309156d,

0.20251756430676127d,

0.6002591094455105d,

0.22668788944083362d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6758315467242458d,

0.7888537282174201d,

0.16784858902265665d,

0.38838079499547806d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.30783024579748575d,

0.6731304494361289d,

0.066776953589757d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.38350113714678724d,

0.9261488446690946d,

0.44432046682068504d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4802447624377649d,

0.3689749503408055d,

0.29473190551071726d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7702697808336355d,

0.3178726917574505d,

0.19098605162129423d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.24862771795727034d,

0.8198950866935611d,

0.43924445775323806d,

0.9525361122430324d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4244300285546623d,

0.9789497070945918d,

0.42049144338186084d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.35697418153987603d,

0.17232342252800492d,

0.08314649531580642d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9946004400382753d,

0.46890781086367894d,

0.5827522125301997d,

0.8770639597018131d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.29047367802032165d,

0.9003563785685343d,

0.3512247805119816d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6490223502724005d,

0.5939871510292214d,

0.12844614407790356d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6381918108765229d,

0.653257605943583d,

0.2985849767321892d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8306863668628313d,

0.3609080497956487d,

0.8860151626505911d,

0.3756823534093475d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.03307624758537475d,

0.7185860404420659d,

0.45326254590240356d,

0.7598367569795756d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.669029908030028d,

0.9106761854272891d,

0.034008399852485605d,

0.7247223936465261d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7693950300687947d,

0.27756908392251767d,

0.39860960773053644d,

0.05570851319137371d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.40571558455262724d,

0.9322543495081559d,

0.6389598113553361d,

0.6328446203536814d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.682614203240393d,

0.2139332893800292d,

0.4610064101791991d,

0.0015680219843842158d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8700105735606514d,

0.35132641062787684d,

0.7562872096797688d,

0.5257002833880874d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.44087443241050317d,

0.7597290813034514d,

0.22511241328433518d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9555372536667824d,

0.38954269999770663d,

0.5291247172702919d,

0.2804414831566715d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8368023431170538d,

0.08515922811981169d,

0.39095628154548956d,

0.37893880604910024d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5878597492834842d,

0.3870395153721913d,

0.9755759946118345d,

0.8729117279071014d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8468666193325234d,

0.764513608524406d,

0.21815145454831075d,

0.3502051113847847d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6977527709204285d,

0.8487340949108808d,

0.11040082002638585d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.37519353814320366d,

0.8215821572572041d,

0.8716048911775278d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7220302313733412d,

0.3083486262821039d,

0.9161753623119484d,

0.04115867782030813d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5034646038297984d,

0.1518826362561605d,

0.5526562510780189d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8929014432265249d,

0.08460905990461642d,

0.2620991357885821d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9013197140557448d,

0.7384979760104191d,

0.4086266620632877d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6555625458358706d,

0.06448285056317271d,

0.5667024614472043d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8901764502739823d,

0.9322859243931239d,

0.42042057363872287d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8571276960862951d,

0.9032759303847875d,

0.693268384771023d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7329555581296142d,

0.10306603256324187d,

0.35112819415010144d,

0.7873555598705041d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.37249550970165923d,

0.07847789807226235d,

0.052425385808323344d,

0.2556552754760182d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9528053147876375d,

0.040634353118804145d,

0.42446244694196844d,

0.06150117579394643d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.48477418840666364d,

0.8023440204358668d,

0.6339019552885817d,

0.7667714377144303d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5088136629596606d,

0.8138140105689661d,

0.8664257048348365d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.910994438925549d,

0.9398060049096683d,

0.6243730674090456d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5008155254358909d,

0.7705237648894919d,

0.3849224455933705d,

0.20846935002236522d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.35871103433769935d,

0.5991109424336711d,

0.2067257680631972d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.04592548733257085d,

0.36360762892212506d,

0.6760904241018297d,

0.7017847313759411d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7254158376381512d,

0.9975278745848837d,

0.8434749924270637d,

0.43710327392649273d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4357770423836299d,

0.5484621226499607d,

0.19529347107514528d,

0.9710584483249575d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7924168215677255d,

0.9105649989490793d,

0.9277496467363592d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6476261256616446d,

0.31269227277287803d,

0.10645921787115598d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.17141888471134314d,

0.17616397655174854d,

0.9512157001119382d,

0.3007715372063834d,

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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 48, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 48, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 98, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 50, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 153, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 70, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 118, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 36, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

