

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
    internal partial interface IDecimalListnumericListD1
    {
    }
    
    internal partial class DecimalListnumericListD1 : IDecimalListnumericListD1
    {


#region TestData

        private readonly DecimalnumericListD1E2M[] _testData = new DecimalnumericListD1E2M[]
        {
            new DecimalnumericListD1E2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.495271091549334m,

0.749050610642206m,

0.295696095714222m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0405719474569121m,

0.0712667139350093m,

0.0512152038863194m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.89194217467201m,

0.952429285097678m,

0.883611971318699m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.879233981601209m,

0.70803882324325m,

0.985511642930234m,

0.740101231733745m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.984343100148408m,

0.521531661487455m,

0.205838932279797m,

0.232548957560583m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17773679248594m,

0.811256745774836m,

0.789420006615395m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.100736868061123m,

0.475855267522287m,

0.704225852618694m,

0.0280426080285129m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.800535926773817m,

0.0712379847960422m,

0.751232613029101m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.279085467968543m,

0.556905892262306m,

0.27381929493751m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.365486012986892m,

0.652765992534557m,

0.671379191293213m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.199375143197622m,

0.728277928548221m,

0.623303651786236m,

0.591019310958744m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.321798816606144m,

0.924627577450832m,

0.798521169839887m,

0.1671558649243m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.62733766546165m,

0.190998853099161m,

0.928163971111984m,

0.81454750620268m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.107139865428388m,

0.27923010042447m,

0.568818418246516m,

0.800769413008391m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.523410016999565m,

0.67408413435721m,

0.555331471032941m,

0.796808661073476m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.556333457674454m,

0.779650247363422m,

0.84828791894462m,

0.94652765569519m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.587435204912386m,

0.864839104388078m,

0.569692189289151m,

0.104829826851714m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.427599604817163m,

0.347964929111926m,

0.474975727343419m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.309631181260506m,

0.195989745185628m,

0.645055412424695m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.662905799718656m,

0.408868474096758m,

0.389048510525804m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.988851840579924m,

0.16732089521303m,

0.921373322763635m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.322089917325049m,

0.356261145619708m,

0.00368391038919991m,

0.128080481441071m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.316850392712657m,

0.0461398584310035m,

0.542103566154259m,

0.839576100769791m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.734927152670772m,

0.421671695573097m,

0.888492379858261m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.238195436989631m,

0.277062363461802m,

0.558363706649936m,

0.177003769232373m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.638290866402547m,

0.783716371372311m,

0.476354085138328m,

0.224975748106139m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.146726085973028m,

0.282767347520533m,

0.811667912245826m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0706958012087193m,

0.311688854619105m,

0.23273312647787m,

0.525299729101782m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.292483143073965m,

0.0209935270166921m,

0.978478244091826m,

0.336293875909712m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.745777577162098m,

0.83206281958914m,

0.677527977053754m,

0.887699634406042m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.995855146931574m,

0.291998915439842m,

0.326197113379588m,

0.0816172070790547m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.825517081605801m,

0.634834685614277m,

0.80556480625397m,

0.769327615895537m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.738666506582372m,

0.543400832790835m,

0.658540168416034m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868951044947698m,

0.961076417683889m,

0.306831950984013m,

0.136149049183341m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.783886104510227m,

0.118633761848628m,

0.503054133870302m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.688976510302587m,

0.763830335951477m,

0.0206757328030177m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.802990954681083m,

0.711429816124906m,

0.399703301534375m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.324851208582634m,

0.585642979522658m,

0.12558168271939m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.174201379510585m,

0.0836668164953792m,

0.496437859875979m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0537212781211789m,

0.710304939774682m,

0.249971892584949m,

0.565144185817974m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0500777995242457m,

0.227340637894931m,

0.367579005351729m,

0.687812180859355m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.392321554661838m,

0.989628683913354m,

0.880846622129863m,

0.00629127782883354m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.767367254411416m,

0.278866550851985m,

0.664284919133518m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0234450580931013m,

0.624229262863518m,

0.47126066083317m,

0.0923124260467336m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.278199840043184m,

0.763142985694289m,

0.0108313373681882m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.673496574452039m,

0.0503600951963262m,

0.440196075391693m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.293136951772135m,

0.827666705471138m,

0.150279395119908m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.959722332805277m,

0.460326204155332m,

0.981982496651103m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.902385019893345m,

0.695501176589383m,

0.540120534169095m,

0.0792048923618804m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.45160277235195m,

0.186533457456977m,

0.0374918633213652m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.504790659886792m,

0.298422726193021m,

0.428012606125018m,

0.646993544588069m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.766407304687069m,

0.765151773378854m,

0.214254005050347m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.879553098196893m,

0.15311180359782m,

0.579375469993075m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.155694272644931m,

0.628440723786281m,

0.989165566336276m,

0.801396101003421m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.852698317696705m,

0.79216053066937m,

0.87074754800536m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.240854608827876m,

0.644184544898081m,

0.164384534581245m,

0.291132870827591m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.681205240735134m,

0.729672098467235m,

0.958239091364469m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78422191119764m,

0.593780469654411m,

0.859666656635672m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.166974865632888m,

0.636001907641503m,

0.0474801838534954m,

0.201529877330334m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.194552186989358m,

0.0515023115658968m,

0.0930741423267641m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.341347856763498m,

0.579698586895715m,

0.362812480394591m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76550917194973m,

0.946159029240031m,

0.919446581150078m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.80504402066488m,

0.0426251285588592m,

0.149504580340384m,

0.475148949145941m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.367966012108188m,

0.982856826056973m,

0.553009658125895m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.97633987090915m,

0.208228885805823m,

0.976478085811916m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.639385538051569m,

0.208309633748964m,

0.248322499487662m,

0.5912344664728m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.123247028958759m,

0.751464512241565m,

0.0932529078863224m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.24714696306399m,

0.000764379183140984m,

0.0900088459886629m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0376471367219264m,

0.56405150592753m,

0.749517865298083m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.388108441381924m,

0.810542868728531m,

0.743063588867066m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.45285061622171m,

0.946254443722354m,

0.100997697316833m,

0.871806999996936m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.343685076527558m,

0.640483525194544m,

0.0771439915742686m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.102020637321306m,

0.459636727329097m,

0.802158974996444m,

0.261841453009933m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.560216584889601m,

0.38429399107916m,

0.460906703317889m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.499810729192257m,

0.122786873877445m,

0.481732009499255m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.345859730829714m,

0.857798676532174m,

0.77288125368868m,

0.329335313913499m,

},
    ModelInner = new DecimalnumericListD12MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.302668317120515m,

0.554626252602119m,

0.827592051275127m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.406773386860118m,

0.198167429796482m,

0.0150611803298522m,

0.488507912234364m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.297821505617889m,

0.27847687855746m,

0.973272617190254m,

0.484385213090421m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.675703188843827m,

0.313510255800815m,

0.543742701631939m,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd12mi(
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd12mi(
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
            queryMapTypes: [typeof(DecimalnumericListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
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

                changedRows =  ((IDecimalListnumericListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd12mi_id
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
            asPartInterface: typeof(IDecimalListnumericListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericlistd12mi_id", 
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
                changedRows =  ((IDecimalListnumericListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd12mi_id
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
    decimalnumericlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd12mi_id
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
    decimalnumericlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericlistd12mi_id", 
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
                List<DecimalnumericListD1E2M> models = null;

                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericListD1E2M> models = null;

                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd12mi mi ON mi.id = m.decimalnumericlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd12mi mi ON mi.id = m.decimalnumericlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 183;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 128;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 183;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd12mi mi ON mi.id = m.decimalnumericlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await((IDecimalListnumericListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IDecimalListnumericListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 34, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 131, query1, 180, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 13, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 86, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 19, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd12mi mi ON mi.id = m.decimalnumericlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await((IDecimalListnumericListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 20, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IDecimalListnumericListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 110, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[7], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[8], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[9], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[10], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[11], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[23],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[24],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[25],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[26],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models =  ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[8], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[9], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[10], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[11], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[23],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[24],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[25],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_decimalnumericlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericListD12MIWA),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericListD12MI),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericlistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericListD1E2M),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
FROM public.binary_decimalnumericlistd1e2m m
LEFT JOIN public.binary_decimalnumericlistd12mi mi ON mi.id = m.decimalnumericlistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericListD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericlistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IDecimalListnumericListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA), typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericListD12MIWA>();
                var models2 = new List<DecimalnumericListD12MIWA>();
                await ((IDecimalListnumericListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD12MIWA>();
                var models2 = new List<DecimalnumericListD12MIWA>();
                ((IDecimalListnumericListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalListnumericListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericlistd12mi
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
                    DecimalnumericListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericlistd12mi
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
                    DecimalnumericListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA), typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models1 = new List<DecimalnumericListD12MIWA>();
                var models2 = new List<DecimalnumericListD12MIWA>();
                await ((IDecimalListnumericListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD12MIWA>();
                var models2 = new List<DecimalnumericListD12MIWA>();
                ((IDecimalListnumericListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models = await ((IDecimalListnumericListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericlistd12mi
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
                    DecimalnumericListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericlistd12mi
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
                    DecimalnumericListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MI), typeof(DecimalnumericListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericListD12MI>();
                var models2 = new List<DecimalnumericListD12MI>();
                await ((IDecimalListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD12MI>();
                var models2 = new List<DecimalnumericListD12MI>();
                ((IDecimalListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalListnumericListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA), typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models1 = new List<DecimalnumericListD12MIWA>();
                var models2 = new List<DecimalnumericListD12MIWA>();
                await ((IDecimalListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD12MIWA>();
                var models2 = new List<DecimalnumericListD12MIWA>();
                ((IDecimalListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models = await ((IDecimalListnumericListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

