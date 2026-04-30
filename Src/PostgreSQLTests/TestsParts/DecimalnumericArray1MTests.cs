

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
    internal partial interface IDecimalArraynumericArray
    {
    }
    
    internal partial class DecimalArraynumericArray : IDecimalArraynumericArray
    {


#region TestData

        private readonly DecimalnumericArray1M[] _testData = new DecimalnumericArray1M[]
        {
            new DecimalnumericArray1M
{
    Id = 1,
    Value = 
new System.Decimal[3]
{
0.804077553514003m,
0.30893650467162m,
0.695026909857662m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 2,
    Value = 
new System.Decimal[4]
{
0.135177771430618m,
0.88259930169756m,
0.737474228297419m,
0.191730743368802m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 9,
    Value = 
new System.Decimal[4]
{
0.0579208960534239m,
0.63948115694122m,
0.383749709573742m,
0.111425866111639m,
},
    NullableValue = 
new System.Decimal[4]
{
0.96875666974138m,
0.587751733619256m,
0.443788517660126m,
0.532943109572988m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.292454118412569m,
0.964535535639484m,
0.569409939127452m,
0.412582854748655m,
},
},
            new DecimalnumericArray1M
{
    Id = 7,
    Value = 
new System.Decimal[4]
{
0.692460480086257m,
0.349010634349288m,
0.243740453536169m,
0.385566872372654m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 16,
    Value = 
new System.Decimal[3]
{
0.218966419038626m,
0.215991536512943m,
0.251089891028998m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 10,
    Value = 
new System.Decimal[4]
{
0.741826684646176m,
0.747066818533641m,
0.081760695667366m,
0.679852529909092m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.903791343153606m,
0.271173812235822m,
0.79590959174057m,
0.851604066512022m,
},
},
            new DecimalnumericArray1M
{
    Id = 24,
    Value = 
new System.Decimal[3]
{
0.157166917623704m,
0.545742546895248m,
0.100248716019537m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.839884689338486m,
0.301884866473026m,
0.965186015079868m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 11,
    Value = 
new System.Decimal[4]
{
0.695412967282312m,
0.400009607471435m,
0.321015129183527m,
0.932498081630132m,
},
    NullableValue = 
new System.Decimal[3]
{
0.165281553818448m,
0.198658707330691m,
0.927840561489356m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 28,
    Value = 
new System.Decimal[3]
{
0.437226961844951m,
0.905368869042724m,
0.268690296223024m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0045582128167404m,
0.445463584591458m,
0.232522581649322m,
},
},
            new DecimalnumericArray1M
{
    Id = 33,
    Value = 
new System.Decimal[4]
{
0.951923189996851m,
0.469952749304207m,
0.470770292564455m,
0.24962072560051m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 20,
    Value = 
new System.Decimal[3]
{
0.397878030680431m,
0.337669293608373m,
0.216540468264302m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 34,
    Value = 
new System.Decimal[4]
{
0.115629680038764m,
0.587221317832259m,
0.117161211115271m,
0.174788601847737m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.703885237239901m,
0.637868177783556m,
0.291527774225933m,
},
},
            new DecimalnumericArray1M
{
    Id = 36,
    Value = 
new System.Decimal[3]
{
0.931689569024543m,
0.81667003425223m,
0.349033117026793m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.877561363290166m,
0.595727012294173m,
0.0147284253999109m,
},
    NullableValue = 
new System.Decimal[4]
{
0.678767750181649m,
0.786922698241484m,
0.0234731091772461m,
0.902131376942255m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.286094484978186m,
0.937084327186066m,
0.493321874893927m,
},
},
            new DecimalnumericArray1M
{
    Id = 38,
    Value = 
new System.Decimal[4]
{
0.560922816519759m,
0.983102615650848m,
0.563138840515143m,
0.0827919606544767m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.384566523313959m,
0.957833020146708m,
0.159217785432563m,
},
},
            new DecimalnumericArray1M
{
    Id = 41,
    Value = 
new System.Decimal[4]
{
0.696709405322056m,
0.9879845345306m,
0.871577969932848m,
0.0785317967129186m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 30,
    Value = 
new System.Decimal[3]
{
0.166987130735826m,
0.798702409969752m,
0.943259933813204m,
},
    NullableValue = 
new System.Decimal[3]
{
0.242867636844098m,
0.302653381836914m,
0.661796176937629m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 46,
    Value = 
new System.Decimal[3]
{
0.724172430204281m,
0.344755716876688m,
0.440348214775954m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 47,
    Value = 
new System.Decimal[4]
{
0.00670521641588129m,
0.256894089036194m,
0.571660896099416m,
0.0202425489577948m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 34,
    Value = 
new System.Decimal[3]
{
0.457419092398368m,
0.570917628498601m,
0.770155755285707m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 53,
    Value = 
new System.Decimal[4]
{
0.479641494442127m,
0.734266640826949m,
0.946983523583497m,
0.966503895486365m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.380381448429262m,
0.947865548188612m,
0.847405597591221m,
0.199935850685829m,
},
},
            new DecimalnumericArray1M
{
    Id = 56,
    Value = 
new System.Decimal[3]
{
0.188959665505604m,
0.637769172139676m,
0.732098056583822m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 35,
    Value = 
new System.Decimal[3]
{
0.96368703108712m,
0.581269128896927m,
0.066716165177663m,
},
    NullableValue = 
new System.Decimal[4]
{
0.86043067093862m,
0.54927261483114m,
0.352244726622462m,
0.407681711359978m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 58,
    Value = 
new System.Decimal[4]
{
0.382315090828924m,
0.891279910524455m,
0.614791208928449m,
0.405301945781634m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.00274823846990169m,
0.986887028916484m,
0.73017873936766m,
},
},
            new DecimalnumericArray1M
{
    Id = 62,
    Value = 
new System.Decimal[4]
{
0.165141823184433m,
0.477981088794374m,
0.623805764035068m,
0.834495113943644m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 43,
    Value = 
new System.Decimal[4]
{
0.165040657929682m,
0.768912475417064m,
0.35618787438399m,
0.723751781731926m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 71,
    Value = 
new System.Decimal[3]
{
0.464177028726532m,
0.258920411196722m,
0.970342079016212m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 77,
    Value = 
new System.Decimal[4]
{
0.677509532677315m,
0.070206437822468m,
0.625087182733545m,
0.212395251987381m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 48,
    Value = 
new System.Decimal[3]
{
0.497404894052263m,
0.167176213924337m,
0.611086243395724m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 83,
    Value = 
new System.Decimal[3]
{
0.884644592270422m,
0.20372152956554m,
0.221446326844011m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 92,
    Value = 
new System.Decimal[4]
{
0.414206589981867m,
0.451080043262113m,
0.140811047596954m,
0.564588129092293m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 50,
    Value = 
new System.Decimal[3]
{
0.0709535427224226m,
0.633330948177332m,
0.374049701591376m,
},
    NullableValue = 
new System.Decimal[3]
{
0.837138893608891m,
0.80275637691893m,
0.13402541093644m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 97,
    Value = 
new System.Decimal[3]
{
0.122590183768466m,
0.856083264835782m,
0.317901079706527m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 105,
    Value = 
new System.Decimal[4]
{
0.985353598040857m,
0.0130686137082698m,
0.559140897211232m,
0.425974611993658m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 59,
    Value = 
new System.Decimal[4]
{
0.63468091330349m,
0.459774440275962m,
0.0862244092893132m,
0.871940292476502m,
},
    NullableValue = 
new System.Decimal[3]
{
0.267314979005787m,
0.0873593446004048m,
0.542452758659826m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 106,
    Value = 
new System.Decimal[3]
{
0.70236057289076m,
0.186153877516901m,
0.22317951317642m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.26498076904352m,
0.276381426643803m,
0.77226365994244m,
},
},
            new DecimalnumericArray1M
{
    Id = 114,
    Value = 
new System.Decimal[3]
{
0.952231619393708m,
0.394181369123272m,
0.58252429275101m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 64,
    Value = 
new System.Decimal[4]
{
0.463138494528331m,
0.872970802797592m,
0.0538426620602894m,
0.664498935213287m,
},
    NullableValue = 
new System.Decimal[3]
{
0.794133444989264m,
0.690098660846226m,
0.843099211721796m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.746337428252642m,
0.440899056576423m,
0.25988044552092m,
},
},
            new DecimalnumericArray1M
{
    Id = 119,
    Value = 
new System.Decimal[3]
{
0.156178097998123m,
0.953256590374466m,
0.980600111952686m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 121,
    Value = 
new System.Decimal[4]
{
0.0977394927130837m,
0.531144002566909m,
0.66886290638378m,
0.363065637444475m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 66,
    Value = 
new System.Decimal[4]
{
0.816833874119553m,
0.499965811579744m,
0.38376066768099m,
0.474124806803402m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.749013482601228m,
0.234295021029487m,
0.933686458576763m,
0.159131529423245m,
},
},
            new DecimalnumericArray1M
{
    Id = 129,
    Value = 
new System.Decimal[4]
{
0.33754169829611m,
0.556872074687131m,
0.458541337909629m,
0.101248605482354m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.589523959358997m,
0.973369205559044m,
0.322568027428162m,
0.883843125079609m,
},
},
            new DecimalnumericArray1M
{
    Id = 135,
    Value = 
new System.Decimal[4]
{
0.807062903959562m,
0.808993338826186m,
0.156844819282236m,
0.470806368019127m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 74,
    Value = 
new System.Decimal[3]
{
0.744967396113763m,
0.474606863949101m,
0.174499548586641m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 136,
    Value = 
new System.Decimal[3]
{
0.204724242225884m,
0.87613973937056m,
0.856434129767552m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 142,
    Value = 
new System.Decimal[3]
{
0.65591334575656m,
0.8217260020894m,
0.238691681065052m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 77,
    Value = 
new System.Decimal[4]
{
0.75924272931952m,
0.56034741195396m,
0.779436806714629m,
0.495515422897049m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 150,
    Value = 
new System.Decimal[3]
{
0.266679270973837m,
0.0635057539398557m,
0.114601394717233m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 154,
    Value = 
new System.Decimal[3]
{
0.123397372181117m,
0.208365435757215m,
0.176081839051569m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 86,
    Value = 
new System.Decimal[4]
{
0.739508578788329m,
0.61416814989721m,
0.473502729810424m,
0.818347955467114m,
},
    NullableValue = 
new System.Decimal[3]
{
0.989231967179712m,
0.445917973806676m,
0.798625446581168m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 162,
    Value = 
new System.Decimal[3]
{
0.339736111231957m,
0.793853812008988m,
0.64921471015788m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.333768760954935m,
0.271272128393517m,
0.41922238072396m,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
            asPartInterface: typeof(IDecimalArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray1mi_id", 
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
                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.0045582128167404m,
0.445463584591458m,
0.232522581649322m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray1mi_id", 
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
                System.Decimal[] nullable = null;
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.703885237239901m,
0.637868177783556m,
0.291527774225933m,
}));
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.286094484978186m,
0.937084327186066m,
0.493321874893927m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.384566523313959m,
0.957833020146708m,
0.159217785432563m,
}));
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;

                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 58, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 34, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 150, query1, 1, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 24, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 41, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 34, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[28],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[29],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));
DecimalnumericArray1M.AssertModel(models[0],_testData[1], false);DecimalnumericArray1M.AssertModel(models[1],_testData[2], false);DecimalnumericArray1M.AssertModel(models[2],_testData[3], false);DecimalnumericArray1M.AssertModel(models[3],_testData[4], false);DecimalnumericArray1M.AssertModel(models[4],_testData[5], false);DecimalnumericArray1M.AssertModel(models[5],_testData[6], false);DecimalnumericArray1M.AssertModel(models[6],_testData[7], false);DecimalnumericArray1M.AssertModel(models[7],_testData[8], false);DecimalnumericArray1M.AssertModel(models[8],_testData[9], false);DecimalnumericArray1M.AssertModel(models[9],_testData[10], false);DecimalnumericArray1M.AssertModel(models[10],_testData[11], false);DecimalnumericArray1M.AssertModel(models[11],_testData[12], false);DecimalnumericArray1M.AssertModel(models[12],_testData[13], false);DecimalnumericArray1M.AssertModel(models[13],_testData[14], false);DecimalnumericArray1M.AssertModel(models[14],_testData[15], false);DecimalnumericArray1M.AssertModel(models[15],_testData[16], false);DecimalnumericArray1M.AssertModel(models[16],_testData[17], false);DecimalnumericArray1M.AssertModel(models[17],_testData[18], false);DecimalnumericArray1M.AssertModel(models[18],_testData[19], false);DecimalnumericArray1M.AssertModel(models[19],_testData[20], false);DecimalnumericArray1M.AssertModel(models[20],_testData[21], false);DecimalnumericArray1M.AssertModel(models[21],_testData[22], false);DecimalnumericArray1M.AssertModel(models[22],_testData[23], false);DecimalnumericArray1M.AssertModel(models[23],_testData[24], false);DecimalnumericArray1M.AssertModel(models[24],_testData[25], false);DecimalnumericArray1M.AssertModel(models[25],_testData[26], false);DecimalnumericArray1M.AssertModel(models[26],_testData[27], false);DecimalnumericArray1M.AssertModel(models[27],_testData[28], false);DecimalnumericArray1M.AssertModel(models[28],_testData[29], false);DecimalnumericArray1M.AssertModel(models[29],_testData[30], false);DecimalnumericArray1M.AssertModel(models[30],_testData[31], false);DecimalnumericArray1M.AssertModel(models[31],_testData[32], false);DecimalnumericArray1M.AssertModel(models[32],_testData[33], false);DecimalnumericArray1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
DecimalnumericArray1M.AssertModel(models[0],_testData[11], false);DecimalnumericArray1M.AssertModel(models[1],_testData[12], false);DecimalnumericArray1M.AssertModel(models[2],_testData[13], false);DecimalnumericArray1M.AssertModel(models[3],_testData[14], false);DecimalnumericArray1M.AssertModel(models[4],_testData[15], false);DecimalnumericArray1M.AssertModel(models[5],_testData[16], false);DecimalnumericArray1M.AssertModel(models[6],_testData[17], false);DecimalnumericArray1M.AssertModel(models[7],_testData[18], false);DecimalnumericArray1M.AssertModel(models[8],_testData[19], false);DecimalnumericArray1M.AssertModel(models[9],_testData[20], false);DecimalnumericArray1M.AssertModel(models[10],_testData[21], false);DecimalnumericArray1M.AssertModel(models[11],_testData[22], false);DecimalnumericArray1M.AssertModel(models[12],_testData[23], false);DecimalnumericArray1M.AssertModel(models[13],_testData[24], false);DecimalnumericArray1M.AssertModel(models[14],_testData[25], false);DecimalnumericArray1M.AssertModel(models[15],_testData[26], false);DecimalnumericArray1M.AssertModel(models[16],_testData[27], false);DecimalnumericArray1M.AssertModel(models[17],_testData[28], false);DecimalnumericArray1M.AssertModel(models[18],_testData[29], false);DecimalnumericArray1M.AssertModel(models[19],_testData[30], false);DecimalnumericArray1M.AssertModel(models[20],_testData[31], false);DecimalnumericArray1M.AssertModel(models[21],_testData[32], false);DecimalnumericArray1M.AssertModel(models[22],_testData[33], false);DecimalnumericArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
FROM public.binary_decimalnumericarray1m m
LEFT JOIN public.binary_decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDecimalArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDecimalArraynumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

