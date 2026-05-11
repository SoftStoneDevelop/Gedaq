

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.952137339077634m,

0.471602418667746m,

0.309057432929489m,

0.312646590485506m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00414905515001862m,

0.839828522374237m,

0.903369697983748m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.973042256785606m,

0.203329878854619m,

0.952817335640492m,

0.482602517096339m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.368037904686308m,

0.662170089616013m,

0.973737010365281m,

0.558001893483176m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.458721346644589m,

0.57450768173875m,

0.233960669178333m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93760030186997m,

0.825010857094808m,

0.584124891535714m,

0.974339237101542m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.388427949536091m,

0.284059906542865m,

0.0364788230738112m,

0.940809199587336m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.163818324569858m,

0.00410767687233526m,

0.229909031538989m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.895720878054797m,

0.380193728867063m,

0.607410169826149m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.097796924221875m,

0.95220213978483m,

0.0334643890490435m,

0.127005748161653m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.191628208672201m,

0.921243943423862m,

0.915187205994691m,

0.0887383176972555m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.71196547102736m,

0.777840223920908m,

0.639995149448926m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.143009887519747m,

0.277817058615745m,

0.799778209862795m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.955228574620316m,

0.807894865907195m,

0.250250361053222m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0520388559624055m,

0.895594538874429m,

0.967234860050009m,

0.00301507267198908m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.407314500701252m,

0.426731881889694m,

0.585180794890648m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.851866220382616m,

0.885887936856714m,

0.683204717831043m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0461667994528112m,

0.929737562342111m,

0.685739687039654m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.587211195676306m,

0.748970037664377m,

0.479591606956703m,

0.0682976573030607m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.364314337545444m,

0.829613139887267m,

0.249584966910488m,

0.460369528270929m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.857135885267829m,

0.882296652694077m,

0.526440375985308m,

0.372305503343237m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.453727629448647m,

0.167338655718897m,

0.556876538067399m,

0.284323888907443m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.839957734669544m,

0.525428192018507m,

0.431267300558042m,

0.0644106204760647m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.567704934803798m,

0.919378930011414m,

0.326680349468038m,

0.680622593892323m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.47603667743543m,

0.469129747626347m,

0.786985958704075m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.386343979442261m,

0.333492789637573m,

0.822293679392337m,

0.669399453172119m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.102395784985706m,

0.753164499616566m,

0.055767653797431m,

0.800537958869382m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.164951309634189m,

0.39237102766353m,

0.279924112057241m,

0.301679760106057m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.801696583829786m,

0.0853859696441135m,

0.908303988712894m,

0.472902827101501m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.6643601955448m,

0.625888397780285m,

0.72939427919931m,

0.521141620871612m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.212976447077478m,

0.639197669053287m,

0.215895338524805m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.851557800213658m,

0.68675034987681m,

0.943461096431313m,

0.407792088859662m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.755062421381577m,

0.0282710888308805m,

0.205280537243228m,

0.203890508516809m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.371446290951017m,

0.996490008159594m,

0.0956401094951823m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.537591263068951m,

0.77597979079509m,

0.21586709395178m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.434618565121913m,

0.59752971321189m,

0.589981663964105m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0823506844961722m,

0.97520306910521m,

0.986428982136491m,

0.515592572096666m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.942947601793074m,

0.179900043439106m,

0.369524793888231m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.494276782590647m,

0.465872720979536m,

0.862143183033894m,

0.701362258541268m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.287708377765204m,

0.441196040599394m,

0.990138678223075m,

0.892738312491778m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.465334871266007m,

0.315292313683556m,

0.471903782935317m,

0.0579171339841901m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.715315031127055m,

0.896175853636215m,

0.0972978024375684m,

0.233715219682186m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.233375654688858m,

0.792137733139708m,

0.987970653254158m,

0.873354823851489m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.610508812508996m,

0.914290582891865m,

0.134074904220119m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.379541081066986m,

0.509894262114675m,

0.672153712247745m,

0.433427190910259m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.135872929025754m,

0.0563559046595855m,

0.979144434708958m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.828559347339162m,

0.667232965459867m,

0.76107832479594m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.247380709661368m,

0.916963820058901m,

0.921317702028457m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.172256799835465m,

0.547100325038061m,

0.150007738538952m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.573596189238664m,

0.265821886389826m,

0.968371758636526m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0693617551635396m,

0.924181862346523m,

0.602903223037221m,

0.912627411922362m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0152775802895231m,

0.546756748187633m,

0.664509247754791m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.556724287659598m,

0.47183260732454m,

0.733721537766896m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.981883474595019m,

0.446487117658792m,

0.961945431239831m,

0.69586359366053m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.180720808754598m,

0.553005945568816m,

0.91698747330372m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108949598834908m,

0.744773732940678m,

0.388888755750558m,

0.756012711636159m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.958328014749254m,

0.0116732613846289m,

0.24476202119814m,

0.679293680972754m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.732553011621042m,

0.982780970021807m,

0.0125019951142978m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.501308996377537m,

0.424559359809479m,

0.717380258903961m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.775939321845623m,

0.86033116127449m,

0.993746422466934m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.158556410456077m,

0.306500954305453m,

0.489617910387052m,

0.455701258667626m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34223019623594m,

0.119508790377464m,

0.706572785616386m,

0.940325158382561m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.805292566336386m,

0.789995034319979m,

0.168413691039961m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.389844857789239m,

0.962507691725833m,

0.419620299648473m,

0.063759913354168m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.51228973467494m,

0.328964016546227m,

0.404418729040093m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.850937506546348m,

0.638169705183828m,

0.205533948279099m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.339549797452645m,

0.589678235093176m,

0.0921334074961212m,

0.761371775512811m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.687534350539036m,

0.386838567678004m,

0.0678172767257271m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.963925987280183m,

0.208749626564262m,

0.787827700872414m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.450187265828698m,

0.979983555363014m,

0.474593297969852m,

0.646430338879432m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.20709997224924m,

0.0863728638859906m,

0.56860680656912m,

0.386465859898251m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.866712128139007m,

0.946687524235966m,

0.562733872509959m,

0.220375529933816m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.421291946818597m,

0.954524479877854m,

0.517189926552705m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.726207509656986m,

0.335582026687461m,

0.770097199837453m,

0.918059888804306m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0973686439599291m,

0.514060941418661m,

0.379574460792776m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.696432229130099m,

0.401450765142929m,

0.274531809147773m,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2mi(
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
INSERT INTO public.decimalnumericlistd1e2mi(
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
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
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
    decimalnumericlistd1e2mi_id
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
                methodParametrName: "decimalnumericlistd1e2mi_id", 
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
    decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
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
    decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
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
                methodParametrName: "decimalnumericlistd1e2mi_id", 
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
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
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
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 109;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
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
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 146, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
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
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 69, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 163, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 17, query1, 29, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 119, query1, 163, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 48, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[34], false);
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
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
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
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 148, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 21, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[34], false);
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
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 48);
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
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models =  ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[3], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[4], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[5], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[6], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[7], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[8], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[9], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[10], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[11], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[23],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[24],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[25],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[26],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[27],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[28],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[29],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[30],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
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
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
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
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
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
COPY public.binary_decimalnumericlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MI),
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
                var importCollection = new List<DecimalnumericListD1E2MI>(2);
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
                    DecimalnumericListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MI>(2);
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
                    DecimalnumericListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
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
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
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
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
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
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
decimalnumericlistd1e2mi_id,
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
LEFT JOIN public.binary_decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
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
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
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
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
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
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI), typeof(DecimalnumericListD1E2MI)],
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
                var models1 = new List<DecimalnumericListD1E2MI>();
                var models2 = new List<DecimalnumericListD1E2MI>();
                await ((IDecimalListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MI>();
                var models2 = new List<DecimalnumericListD1E2MI>();
                ((IDecimalListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
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
                    DecimalnumericListD1E2MI.AssertModel(model, expectedModel, false);
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
                    DecimalnumericListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

