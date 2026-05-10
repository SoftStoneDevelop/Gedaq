

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
    internal partial interface IDecimalListnumericArray
    {
    }
    
    internal partial class DecimalListnumericArray : IDecimalListnumericArray
    {


#region TestData

        private readonly DecimalnumericArray2M[] _testData = new DecimalnumericArray2M[]
        {
            new DecimalnumericArray2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.218334505546889m,

0.0401160857205319m,

0.71364992393804m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.000490813929465039m,

0.31819149679547m,

0.863404748176297m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.958018978714914m,

0.24438909406735m,

0.658008189438551m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.694489654882983m,

0.396152327114498m,

0.734108529007806m,

0.562735816847188m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.416564305235896m,

0.840017658562648m,

0.984181825058293m,

0.916056772250883m,

},
},
            new DecimalnumericArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.329295610351166m,

0.935083725665528m,

0.746529129779081m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.696782103483555m,

0.872113437487581m,

0.0879015674531852m,

0.188617697695972m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.229941790882431m,

0.159390841231766m,

0.886412856151885m,

0.53453650645695m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.800680043310751m,

0.840346332015588m,

0.568556661014789m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.558370024484499m,

0.6743333996979m,

0.622545182876366m,

0.192640706802295m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0355977458673963m,

0.808814743162584m,

0.900721338383371m,

0.768309023324709m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.404019464341847m,

0.473882448724754m,

0.503044211972244m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.890111205145701m,

0.652012014610139m,

0.572547489110612m,

},
},
            new DecimalnumericArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.79629826631694m,

0.798485329771152m,

0.118180208703021m,

0.521113465310352m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.416743648794287m,

0.835693991858236m,

0.51930308437m,

},
},
            new DecimalnumericArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.999701282039819m,

0.271965463956093m,

0.567783113594057m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.643924079510784m,

0.0403166448331497m,

0.221498353710777m,

0.842462358755967m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.819787922569451m,

0.0537411437844881m,

0.318312696187636m,

0.387577595856409m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.411984608186666m,

0.888848654705246m,

0.0411890891656272m,

0.783806603292136m,

},
},
            new DecimalnumericArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.620535268994492m,

0.598324775429018m,

0.832576037132309m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.461822586230366m,

0.573819384077281m,

0.582434667925126m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.898958076172625m,

0.820705998878743m,

0.96989648105862m,

0.892460949558782m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.177390949175923m,

0.185452786002762m,

0.326086437460611m,

0.357412234643598m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.280191848511183m,

0.440438579607997m,

0.062081731389828m,

},
},
            new DecimalnumericArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.436591636954325m,

0.791267529739087m,

0.602599525991225m,

0.533692153654961m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.100054747107356m,

0.72449121433877m,

0.875245255678975m,

0.46769384694399m,

},
},
            new DecimalnumericArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.614309318102207m,

0.345088894542291m,

0.646127273106437m,

0.190926995352803m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.44449227808411m,

0.714573212548266m,

0.393889042062051m,

0.840317953444692m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54600312878358m,

0.889558257260552m,

0.242340343136816m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.814702650739087m,

0.934889680883351m,

0.182706972562038m,

},
},
            new DecimalnumericArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.920070345434526m,

0.552848372161541m,

0.680974821621481m,

0.848348805978474m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.764328935223386m,

0.662177957331718m,

0.955241626346979m,

0.111115101999322m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.661270053408928m,

0.0828419097418277m,

0.302043780739761m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.617932149258413m,

0.878365353777483m,

0.0462260404316052m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.984433688743797m,

0.807229150101533m,

0.402776430139191m,

0.298660480284583m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0844557253806443m,

0.190090660607571m,

0.498574817715858m,

0.0251001888616024m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88658909605063m,

0.846723195159846m,

0.798561725459027m,

0.372697029344595m,

},
},
            new DecimalnumericArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0182880413595935m,

0.525773574562897m,

0.566046708318508m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0261593648046392m,

0.12155861918383m,

0.500073445025801m,

0.600612028912322m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54942497499335m,

0.988365777702892m,

0.907865016865383m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.586525852394741m,

0.645985271728145m,

0.937973325474039m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.734222539185626m,

0.114208039580415m,

0.635086941052099m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.428297522497338m,

0.59231890857956m,

0.505210130437101m,

0.0840183846058767m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.306463995396951m,

0.537724627108514m,

0.505130879666223m,

},
},
            new DecimalnumericArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.335454812202279m,

0.523805160428818m,

0.645371519407584m,

0.804015747226191m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.977296944776521m,

0.89105944839535m,

0.0348354425968382m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.782857871547802m,

0.0539772569571262m,

0.342236663348533m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.74873236647237m,

0.172840841917578m,

0.103618009101958m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.766695997651047m,

0.609397140189877m,

0.771282996595791m,

0.815323597502853m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.102894562964654m,

0.742988454314877m,

0.765589678803663m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.956490351541538m,

0.227429993096371m,

0.315235704471092m,

0.0128675862683844m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.736034072176619m,

0.825229700794633m,

0.141357018111892m,

0.190333416473301m,

},
},
            new DecimalnumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.149420529202098m,

0.327716781108523m,

0.442619427071165m,

0.792273331319928m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.267574377612299m,

0.779512776862619m,

0.310424623541186m,

0.148390479397496m,

},
},
            new DecimalnumericArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.977779806983888m,

0.0478950585768247m,

0.962883431501396m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0807685508555799m,

0.814186657198797m,

0.0980525282835006m,

0.994214493236614m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.469509221732305m,

0.955492677454681m,

0.40271551176178m,

0.833740531536718m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768003153742951m,

0.130187977735825m,

0.353510665730928m,

0.546113351878206m,

},
},
            new DecimalnumericArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.408131536072651m,

0.276192872092869m,

0.271569765841518m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213783462944397m,

0.327565225538825m,

0.903315854157396m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.21896779081416m,

0.890042731260268m,

0.756811214533218m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.989450885932256m,

0.522714274660092m,

0.0610448883398684m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.46509483171104m,

0.858298696776464m,

0.380315768595197m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.781678024604561m,

0.950231532678864m,

0.873611325315787m,

},
},
            new DecimalnumericArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.421954800463934m,

0.885396977508286m,

0.767749307515257m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.814965196811716m,

0.626840846150045m,

0.559576975300037m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.94009367406968m,

0.357133086489843m,

0.740198258403718m,

0.850151756469868m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.75893540790865m,

0.144000482208105m,

0.371480695081033m,

0.58016395172581m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.995578101641853m,

0.74139121918309m,

0.440168841647612m,

0.346653844240246m,

},
},
            new DecimalnumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.590390216330584m,

0.94534446925052m,

0.575883899657813m,

0.803738166559132m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662404193980444m,

0.332227982450983m,

0.880418740395922m,

0.47500859081006m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0172786997613867m,

0.5976370194767m,

0.863737863645034m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.85468600784584m,

0.198307622083651m,

0.797859897313459m,

0.021956248830504m,

},
},
            new DecimalnumericArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.698747300855917m,

0.143926811605989m,

0.173244621811106m,

0.538445602887655m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0654448598246072m,

0.669043389341552m,

0.532272956848042m,

0.573179067068864m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.536299453472126m,

0.327456909054961m,

0.572042353908535m,

0.606427871949236m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979268202935936m,

0.652252602510971m,

0.35704785941611m,

},
},
            new DecimalnumericArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.746182800221822m,

0.889032321176758m,

0.27992280679954m,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
INSERT INTO public.decimalnumericarray2mi(
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
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
            asPartInterface: typeof(IDecimalListnumericArray)), 
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
                methodParametrName: "decimalnumericarray2mi_id", 
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
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                methodParametrName: "decimalnumericarray2mi_id", 
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
                List<DecimalnumericArray2M> models = null;

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 39;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[34], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 109, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 39, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 64, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 70, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[30],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 47, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[34], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 43, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                DecimalnumericArray2M.AssertModel(models[0],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[29], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[30], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[31], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[32], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[33], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                DecimalnumericArray2M.AssertModel(models[0],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[14], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[15], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[16], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[17], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[18], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[19], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[15],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[16],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[17],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[18],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[19],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[20],_testData[29], false);
                DecimalnumericArray2M.AssertModel(models[21],_testData[30], false);
                DecimalnumericArray2M.AssertModel(models[22],_testData[31], false);
                DecimalnumericArray2M.AssertModel(models[23],_testData[32], false);
                DecimalnumericArray2M.AssertModel(models[24],_testData[33], false);
                DecimalnumericArray2M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray2M),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2m m
LEFT JOIN public.binary_decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models =  ((IDecimalListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models = await ((IDecimalListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI), typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models1 = new List<DecimalnumericArray2MI>();
                var models2 = new List<DecimalnumericArray2MI>();
                await ((IDecimalListnumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MI>();
                var models2 = new List<DecimalnumericArray2MI>();
                ((IDecimalListnumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

