

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.883072032988602m,

0.499116850289832m,

0.347979052343135m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.151005972436353m,

0.718996481813312m,

0.862974167090286m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.934819741713154m,

0.937263637873176m,

0.194087206658993m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.343733747306088m,

0.389636824820617m,

0.562217935551651m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.591521791336206m,

0.886083455065578m,

0.441727388181133m,

},
},
            new DecimalnumericArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.427790616440359m,

0.571310351866407m,

0.783470005496106m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30685403976723m,

0.459389126076697m,

0.904306107108751m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.4575427473034m,

0.801694076994526m,

0.350141116505924m,

},
},
            new DecimalnumericArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.90460342432347m,

0.345265723037892m,

0.332417452325828m,

0.998318803115506m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.424708087780731m,

0.0975561580311901m,

0.122325475082015m,

},
},
            new DecimalnumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.226900046227931m,

0.352877171119081m,

0.682047460844045m,

0.402929644030167m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.152439600570971m,

0.505286000446311m,

0.379377770431798m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.867864342272259m,

0.0047510996094039m,

0.525347192908412m,

0.221488775963651m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.441914826982646m,

0.87216530075024m,

0.970773118429944m,

},
},
            new DecimalnumericArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.314791771725032m,

0.895335907796555m,

0.057728143763908m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.255356841383507m,

0.534162093121332m,

0.151547328913596m,

0.643321983386551m,

},
},
            new DecimalnumericArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.49661119195074m,

0.193797243540886m,

0.145853917881177m,

0.337814473379342m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.082856325383805m,

0.910017113597124m,

0.880638559626134m,

0.925105130658415m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.418171068844592m,

0.268532298307351m,

0.175518061699521m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.446360572836851m,

0.862989966108924m,

0.291223277689923m,

0.656745178672897m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.381056130974856m,

0.414476077216465m,

0.83213029380274m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.351580788830366m,

0.351918875889724m,

0.0387837955549128m,

0.765253716684664m,

},
},
            new DecimalnumericArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.206584444354631m,

0.556432132677177m,

0.792939633419962m,

0.546815752102002m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.338933524169287m,

0.644199073551093m,

0.276813161985586m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.427427767235533m,

0.0507199960635883m,

0.153268826807838m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.106261871787293m,

0.39121056726865m,

0.00827658426402789m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.655773605011312m,

0.130567686658116m,

0.353186093970025m,

0.348362777624317m,

},
},
            new DecimalnumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.99358956353368m,

0.113639616089611m,

0.957442209539816m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.491439019827012m,

0.457882267577144m,

0.169579907129689m,

},
},
            new DecimalnumericArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.920304446539101m,

0.360758647362541m,

0.489707328933652m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.782500314866618m,

0.0204462670306769m,

0.140417995751135m,

0.572152904536194m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0520412914585274m,

0.661424849130184m,

0.576962860737913m,

0.317535972068552m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.705784484417349m,

0.964137469103765m,

0.0411189571948842m,

0.359588654994126m,

},
},
            new DecimalnumericArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32395066304144m,

0.565638850614751m,

0.638607658778906m,

0.572090225854699m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.931142045591163m,

0.214346598304952m,

0.59707620372998m,

0.993619902432701m,

},
},
            new DecimalnumericArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.58869684885788m,

0.894300658454108m,

0.21044501782166m,

0.541845117210367m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.555776996523483m,

0.715646853396139m,

0.610096431125605m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.614358694444002m,

0.0719664690533307m,

0.730899607017078m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.360272894747919m,

0.472757931568685m,

0.879501593670976m,

},
},
            new DecimalnumericArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.148496035976794m,

0.121077579359189m,

0.327999278816894m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.991676575973484m,

0.563313016308475m,

0.797421863155767m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.729117424801621m,

0.688003245141389m,

0.791310226046177m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.805565151360821m,

0.563238453170056m,

0.890531963408624m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.657232696610203m,

0.399917337531016m,

0.723379120197049m,

},
},
            new DecimalnumericArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.724086774035906m,

0.0951222923353813m,

0.267949179092422m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0964102628100824m,

0.395232192003128m,

0.0691366524635877m,

0.624328360090945m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.181095660265358m,

0.783734763603863m,

0.101048471051014m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.361205069589729m,

0.842555917911789m,

0.854036402740389m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868739618142134m,

0.973609396940786m,

0.361017558668292m,

},
},
            new DecimalnumericArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.55792459759176m,

0.16340053508525m,

0.711298393154457m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.532446324163272m,

0.867384575288236m,

0.441428775484582m,

0.0766371518867364m,

},
},
            new DecimalnumericArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.764759032810742m,

0.632256662251421m,

0.778088081151682m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.366532890705226m,

0.404710027058385m,

0.368846417082783m,

0.0861050087493039m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.459119844307364m,

0.402776039464589m,

0.16530256605674m,

0.322375701989065m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.414409706398962m,

0.621635845954753m,

0.923700764657784m,

0.190884383296155m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.236594513445728m,

0.888506952036624m,

0.58798446037967m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.794709951129951m,

0.126175698882844m,

0.189575700597752m,

0.0647738016218733m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.490492090586699m,

0.463526018043655m,

0.502377753443835m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.914233440161039m,

0.636390605628222m,

0.650280762790328m,

},
},
            new DecimalnumericArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.772153013620468m,

0.157431118261072m,

0.475820031079362m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.683439902427056m,

0.704114307608512m,

0.800931301677368m,

0.440181753441622m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.651994670713071m,

0.410923986923695m,

0.894065570791238m,

0.439688130735527m,

},
},
            new DecimalnumericArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.287437133577967m,

0.437529338664044m,

0.589124422283567m,

0.425730969941002m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.802191824861087m,

0.0381653866299039m,

0.997800479986661m,

},
},
            new DecimalnumericArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.910469411599994m,

0.496502939379725m,

0.871946890875601m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.297729850360216m,

0.978922275664135m,

0.188728880250243m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.233956696071131m,

0.470915778384389m,

0.737749398716756m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.727060564530906m,

0.239877588344995m,

0.549317607491849m,

0.0876610112365566m,

},
},
            new DecimalnumericArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.939839543692178m,

0.976308813767708m,

0.722154444627841m,

0.829619019328721m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.575814755580647m,

0.717452842296005m,

0.199263515915325m,

},
},
            new DecimalnumericArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0251794803660103m,

0.285920388746972m,

0.275698060267408m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.862492709346661m,

0.628464561043839m,

0.0419573103995524m,

0.817795290056472m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.214236438517627m,

0.0185997229850036m,

0.874556610194451m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.777040750750062m,

0.77806716610352m,

0.972301004102078m,

0.179229688505067m,

},
},
            new DecimalnumericArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.858983119272635m,

0.05623410517488m,

0.552077549291616m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.444262827846621m,

0.242539962905486m,

0.714241162959974m,

},
},
            new DecimalnumericArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.357642044956485m,

0.729575545158226m,

0.0919642961772689m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.651327540269449m,

0.616818664342237m,

0.488877067779681m,

0.503768288745004m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.526470477467846m,

0.134005900960203m,

0.625748369371371m,

},
},
            new DecimalnumericArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.461922875330868m,

0.638830112048659m,

0.281305153709885m,

0.88753238993834m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.367390984239376m,

0.0987471432585919m,

0.868815253819789m,

0.314284785440076m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.500672180273442m,

0.244464343686813m,

0.146595821961424m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.860978667854952m,

0.786495201834791m,

0.658240789592411m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.648467699151144m,

0.973097740693012m,

0.372885604622561m,

0.817718971057198m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.162824175058916m,

0.476548737762542m,

0.183090843825623m,

0.90844505295822m,

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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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

                    if(resultIndex == 2)
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 164, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 72, query1, 178, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 101, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 28, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 171, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 83, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 140, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[32],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 140, 126))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[34], false);
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
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
DecimalnumericArray2M.AssertModel(models[0],_testData[7], false);DecimalnumericArray2M.AssertModel(models[1],_testData[8], false);DecimalnumericArray2M.AssertModel(models[2],_testData[9], false);DecimalnumericArray2M.AssertModel(models[3],_testData[10], false);DecimalnumericArray2M.AssertModel(models[4],_testData[11], false);DecimalnumericArray2M.AssertModel(models[5],_testData[12], false);DecimalnumericArray2M.AssertModel(models[6],_testData[13], false);DecimalnumericArray2M.AssertModel(models[7],_testData[14], false);DecimalnumericArray2M.AssertModel(models[8],_testData[15], false);DecimalnumericArray2M.AssertModel(models[9],_testData[16], false);DecimalnumericArray2M.AssertModel(models[10],_testData[17], false);DecimalnumericArray2M.AssertModel(models[11],_testData[18], false);DecimalnumericArray2M.AssertModel(models[12],_testData[19], false);DecimalnumericArray2M.AssertModel(models[13],_testData[20], false);DecimalnumericArray2M.AssertModel(models[14],_testData[21], false);DecimalnumericArray2M.AssertModel(models[15],_testData[22], false);DecimalnumericArray2M.AssertModel(models[16],_testData[23], false);DecimalnumericArray2M.AssertModel(models[17],_testData[24], false);DecimalnumericArray2M.AssertModel(models[18],_testData[25], false);DecimalnumericArray2M.AssertModel(models[19],_testData[26], false);DecimalnumericArray2M.AssertModel(models[20],_testData[27], false);DecimalnumericArray2M.AssertModel(models[21],_testData[28], false);DecimalnumericArray2M.AssertModel(models[22],_testData[29], false);DecimalnumericArray2M.AssertModel(models[23],_testData[30], false);DecimalnumericArray2M.AssertModel(models[24],_testData[31], false);DecimalnumericArray2M.AssertModel(models[25],_testData[32], false);DecimalnumericArray2M.AssertModel(models[26],_testData[33], false);DecimalnumericArray2M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
DecimalnumericArray2M.AssertModel(models[0],_testData[10], false);DecimalnumericArray2M.AssertModel(models[1],_testData[11], false);DecimalnumericArray2M.AssertModel(models[2],_testData[12], false);DecimalnumericArray2M.AssertModel(models[3],_testData[13], false);DecimalnumericArray2M.AssertModel(models[4],_testData[14], false);DecimalnumericArray2M.AssertModel(models[5],_testData[15], false);DecimalnumericArray2M.AssertModel(models[6],_testData[16], false);DecimalnumericArray2M.AssertModel(models[7],_testData[17], false);DecimalnumericArray2M.AssertModel(models[8],_testData[18], false);DecimalnumericArray2M.AssertModel(models[9],_testData[19], false);DecimalnumericArray2M.AssertModel(models[10],_testData[20], false);DecimalnumericArray2M.AssertModel(models[11],_testData[21], false);DecimalnumericArray2M.AssertModel(models[12],_testData[22], false);DecimalnumericArray2M.AssertModel(models[13],_testData[23], false);DecimalnumericArray2M.AssertModel(models[14],_testData[24], false);DecimalnumericArray2M.AssertModel(models[15],_testData[25], false);DecimalnumericArray2M.AssertModel(models[16],_testData[26], false);DecimalnumericArray2M.AssertModel(models[17],_testData[27], false);DecimalnumericArray2M.AssertModel(models[18],_testData[28], false);DecimalnumericArray2M.AssertModel(models[19],_testData[29], false);DecimalnumericArray2M.AssertModel(models[20],_testData[30], false);DecimalnumericArray2M.AssertModel(models[21],_testData[31], false);DecimalnumericArray2M.AssertModel(models[22],_testData[32], false);DecimalnumericArray2M.AssertModel(models[23],_testData[33], false);DecimalnumericArray2M.AssertModel(models[24],_testData[34], false);
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                var models = ((IDecimalListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

