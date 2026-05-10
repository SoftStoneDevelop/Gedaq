

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.931054401890368m,

0.368311524945553m,

0.158168498706m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.199154452511932m,

0.148141086523129m,

0.758985656642728m,

0.625193542161494m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.702021796916481m,

0.320847306447234m,

0.972163134120751m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.906766946441846m,

0.641730066076268m,

0.0816894764757094m,

0.347292405309868m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.627546038234274m,

0.887656922311506m,

0.434664704174179m,

},
},
            new DecimalnumericArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.499575062693681m,

0.802904851934214m,

0.717666009124415m,

0.191446719192648m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0821870440692415m,

0.164895153857631m,

0.0785861381596503m,

0.620418440441498m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.650872001818535m,

0.664268899949501m,

0.826098236806583m,

0.869003417000993m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0875429171291241m,

0.37623236249969m,

0.988600522362021m,

0.359496160412276m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.919358789925906m,

0.212521846081198m,

0.32935833167144m,

0.730119936632084m,

},
},
            new DecimalnumericArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.793359909670256m,

0.272242308822231m,

0.0570233859253151m,

0.685422549197062m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.930240562110708m,

0.164892852651272m,

0.186288376338829m,

0.283179773227231m,

},
},
            new DecimalnumericArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.390018501022446m,

0.00126961400141534m,

0.589235966316196m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.175699077317308m,

0.704308678915492m,

0.476565276792636m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.850318680200168m,

0.458466239506709m,

0.0316416131642484m,

},
},
            new DecimalnumericArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.291943107944425m,

0.0599891939889072m,

0.00795875548922698m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.149344825535061m,

0.632487412671252m,

0.279191927415984m,

0.448096524618295m,

},
},
            new DecimalnumericArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.726999015009893m,

0.224770470803096m,

0.153212643876757m,

0.206716907532505m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.229309552508214m,

0.382192297785233m,

0.196346745003443m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.394327024934051m,

0.800937388522172m,

0.630601673014106m,

0.683204231146562m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.645093722019364m,

0.668902035802888m,

0.0803615078142771m,

},
},
            new DecimalnumericArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.360322627606762m,

0.00801449199955862m,

0.140012069040871m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.431453410742257m,

0.69437082739806m,

0.0704814804590042m,

0.708284736076509m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.234859001690262m,

0.169303640285391m,

0.948286944143114m,

0.156409078116495m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.65996854535817m,

0.340978194152795m,

0.839396407337508m,

0.782563130752734m,

},
},
            new DecimalnumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.481563566933853m,

0.351631355886373m,

0.0136517920137506m,

0.305440687687699m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.79053978299387m,

0.384812567536713m,

0.493101975240694m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.525763623518359m,

0.301280815035998m,

0.49118346647874m,

0.965333204841529m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.373197054211826m,

0.0714826266253703m,

0.30718773687186m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.452921088067152m,

0.574216372401023m,

0.372868105363332m,

0.640579193950752m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.749233719487018m,

0.911782600500254m,

0.784741753404092m,

},
},
            new DecimalnumericArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.780242891291633m,

0.416990362841834m,

0.496484907409055m,

0.441082163412854m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.484101250198796m,

0.777495180378889m,

0.97307303874564m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.788563749158217m,

0.0250477150463415m,

0.728888755099216m,

0.7292595277184m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0372478333758043m,

0.734701004968824m,

0.969077477816804m,

0.866353307173016m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.53589911884263m,

0.435280583014541m,

0.763919448498411m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.648768172109722m,

0.00936336477922073m,

0.452011569889187m,

0.790630543378159m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.311496964490061m,

0.0389957036699078m,

0.0638646367974975m,

},
},
            new DecimalnumericArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96931114051152m,

0.40069600839599m,

0.198282824948503m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.776068579544344m,

0.322897556288065m,

0.471978704951236m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.261496837097703m,

0.978771446339352m,

0.804840427701285m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.878226208329803m,

0.462600512438682m,

0.690694571695534m,

0.437918342344761m,

},
},
            new DecimalnumericArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.212844675364944m,

0.964873899023236m,

0.198125755146735m,

0.901289843173088m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.881754795506229m,

0.859751274741125m,

0.0500304059938227m,

0.0959046216154995m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.232829959384419m,

0.550752540603035m,

0.0719852838063809m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.898929152185428m,

0.890780543684177m,

0.565514016686212m,

},
},
            new DecimalnumericArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.680171748428869m,

0.504769699916098m,

0.336413118974966m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.816703591572751m,

0.466679982325985m,

0.330918545168142m,

0.248574087018017m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.912601720599119m,

0.463339152020084m,

0.0464754138309014m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632413911536066m,

0.602246315263607m,

0.188165479943404m,

0.936537852851182m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.398456477273696m,

0.542250436300199m,

0.427782677875859m,

0.73378873190144m,

},
},
            new DecimalnumericArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.815379150632006m,

0.103768022091113m,

0.853201365889647m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.926570618268707m,

0.777627115372394m,

0.640225249842881m,

0.276242987082678m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.861437253108958m,

0.975256037239027m,

0.746917261995325m,

0.677204068376544m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.103565670663243m,

0.435836506706785m,

0.844849089274146m,

},
},
            new DecimalnumericArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.99313000864105m,

0.193021147639262m,

0.0494474797753369m,

0.864366592843505m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0248301369321017m,

0.655321212136956m,

0.822998963287937m,

0.231658579066364m,

},
},
            new DecimalnumericArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.519182250671606m,

0.254014315687561m,

0.996370120544318m,

0.54018834850395m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.704426774662056m,

0.148274551062438m,

0.69948275124175m,

0.251708564466988m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.110542762949624m,

0.18532779320921m,

0.911666840658672m,

0.190033959543627m,

},
},
            new DecimalnumericArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.809107442812924m,

0.609535163605996m,

0.826953716487973m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.942424286492199m,

0.458385151641784m,

0.556467409583774m,

0.149377182045158m,

},
},
            new DecimalnumericArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0734327452521147m,

0.0793567468672582m,

0.0169318730180701m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.927835015631232m,

0.484912104617183m,

0.338815039779703m,

0.0740987843998248m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0697047030775954m,

0.515814015767472m,

0.666644510758949m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.736864338591355m,

0.0449547711683332m,

0.428896405713246m,

},
},
            new DecimalnumericArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.699505411389285m,

0.208719969159967m,

0.0606276961827261m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.197326426852669m,

0.455567216020319m,

0.452173690410806m,

0.0111431441602965m,

},
},
            new DecimalnumericArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.709609162053915m,

0.694125904428338m,

0.0944386944606376m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.124501129285055m,

0.802491527679768m,

0.890872767509276m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.81096529236363m,

0.907049424073386m,

0.959316921041149m,

0.65916670510036m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.696368951958505m,

0.0161012715175675m,

0.0691966205257112m,

},
},
            new DecimalnumericArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.934648225395746m,

0.285928179111969m,

0.82923116036112m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.479150234702054m,

0.460040663968558m,

0.0399840033204669m,

},
},
            new DecimalnumericArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.139970220270314m,

0.577821146143066m,

0.0916411159055175m,

0.871451081664797m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14791192943755m,

0.707477199390095m,

0.903091279615376m,

0.0393540507136346m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.989267341839107m,

0.21750072042512m,

0.468600734060591m,

},
},
            new DecimalnumericArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.586171195531715m,

0.16579161172153m,

0.825932035874938m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.308488024751256m,

0.754307351928244m,

0.999409506496012m,

0.967926794241342m,

},
},
            new DecimalnumericArray2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.89818600168071m,

0.0892726940220219m,

0.809373837558012m,

0.176596162790358m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0300442954082892m,

0.458220895438766m,

0.895640988951252m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.824503632314976m,

0.167493269890783m,

0.0710095987384789m,

},
},
            new DecimalnumericArray2M
{
    Id = 193,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138111372461002m,

0.40160012306265m,

0.633395358324531m,

0.751296131557038m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.97539622460111m,

0.440920079476852m,

0.614967148881247m,

0.874679384706238m,

},
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 131;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 176, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 39, query1, 176, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 176, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 30, query1, 82, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 91, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 46, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 153, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 58, 110))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 153, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[34], false);
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
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                DecimalnumericArray2M.AssertModel(models[0],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[30], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[31], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[32], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[33], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                DecimalnumericArray2M.AssertModel(models[0],_testData[17], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[18], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[19], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[29], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[30], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[31], false);
                DecimalnumericArray2M.AssertModel(models[15],_testData[32], false);
                DecimalnumericArray2M.AssertModel(models[16],_testData[33], false);
                DecimalnumericArray2M.AssertModel(models[17],_testData[34], false);
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

