

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
    internal partial interface IDecimalMArraynumericMMArrayD2
    {
    }
    
    internal partial class DecimalMArraynumericMMArrayD2 : IDecimalMArraynumericMMArrayD2
    {


#region TestData

        private readonly DecimalnumericMMArrayD2E1M[] _testData = new DecimalnumericMMArrayD2E1M[]
        {
            new DecimalnumericMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Decimal[,] { { 0.816376345426408m, 0.556579233242015m, }, { 0.884590713946837m, 0.594899900332437m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.148701241433194m, 0.317630477692627m, }, { 0.367721018977535m, 0.0156785933131307m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Decimal[,] { { 0.478231961655479m, 0.5353313875159m, }, { 0.607325620685881m, 0.0229827957687971m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Decimal[,] { { 0.525280791724127m, 0.350014829518302m, }, { 0.393050065900584m, 0.940366286562256m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.393926601596433m, 0.996072519425944m, }, { 0.602818635323639m, 0.730313870359397m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Decimal[,] { { 0.0217907580494505m, 0.806791880231374m, }, { 0.28524689982464m, 0.658735213105585m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.520612582436335m, 0.276256959816141m, }, { 0.987942760705647m, 0.752070804564157m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Decimal[,] { { 0.654226225700071m, 0.499822124425522m, }, { 0.737382152148969m, 0.330525065306037m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Decimal[,] { { 0.213310547214251m, 0.298309428148474m, }, { 0.736208343054965m, 0.909375222273254m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.407945862872239m, 0.917276148037551m, }, { 0.752253245592551m, 0.884224486421464m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Decimal[,] { { 0.82281100274076m, 0.87266861540543m, }, { 0.20504889452934m, 0.0750323670118637m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.81254032466177m, 0.478703654987088m, }, { 0.629268442267919m, 0.105970481741115m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Decimal[,] { { 0.0961555183061047m, 0.872485912539015m, }, { 0.127979146454542m, 0.871654609571914m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Decimal[,] { { 0.58663712527485m, 0.0111929523664459m, }, { 0.0406145711542558m, 0.39729476025205m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.693587737059284m, 0.358962506255685m, }, { 0.306129654138845m, 0.425716651675119m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Decimal[,] { { 0.198955643404049m, 0.102713642378048m, }, { 0.786939310367138m, 0.953823461091766m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Decimal[,] { { 0.271573297183984m, 0.768433452517271m, }, { 0.691257509046638m, 0.734422968309584m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Decimal[,] { { 0.16706422979695m, 0.331366864069146m, }, { 0.407426625504872m, 0.989431979755966m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.0988178384126843m, 0.737784292079456m, }, { 0.410190098105454m, 0.962307526717467m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.583458645433983m, 0.946497470844002m, }, { 0.963073018178216m, 0.210738993851991m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Decimal[,] { { 0.69973902091271m, 0.894291894625379m, }, { 0.0520492131424117m, 0.0512565627544743m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.861766269915668m, 0.571857198948944m, }, { 0.0164173380491022m, 0.131785305166867m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Decimal[,] { { 0.783691616366519m, 0.26216672288553m, }, { 0.194790131253556m, 0.550216628987923m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Decimal[,] { { 0.0747393624458618m, 0.48313859639583m, }, { 0.383903599074702m, 0.899439826344537m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.760222166238826m, 0.548682181819929m, }, { 0.735541690204902m, 0.789546092428186m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Decimal[,] { { 0.908232433074991m, 0.253947442510831m, }, { 0.68916932024637m, 0.463482780820924m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Decimal[,] { { 0.07566918874295m, 0.499857153869278m, }, { 0.527610136841787m, 0.491844928796358m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Decimal[,] { { 0.973910740707848m, 0.113051755645404m, }, { 0.163556716560589m, 0.0446396344462355m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.667865377327676m, 0.384120301670243m, }, { 0.185029204856948m, 0.79174601808175m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Decimal[,] { { 0.945126625573959m, 0.703576997735725m, }, { 0.329880686463286m, 0.218108706177259m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.961162688465534m, 0.312213139303039m, }, { 0.568214341849608m, 0.213798654871637m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 75,
    Value = 
new System.Decimal[,] { { 0.966543872114654m, 0.792030692566146m, }, { 0.68006024001936m, 0.81302793190121m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Decimal[,] { { 0.123808167962575m, 0.298377828281918m, }, { 0.28613852073193m, 0.231778029837151m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.744916637732224m, 0.89294597212626m, }, { 0.261218434212412m, 0.585586840913787m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Decimal[,] { { 0.166170653497196m, 0.27164001117597m, }, { 0.586462111249366m, 0.786461183026361m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Decimal[,] { { 0.32309764618436m, 0.499512137222706m, }, { 0.0229390295244437m, 0.247049459269618m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Decimal[,] { { 0.640239835823403m, 0.728515702541019m, }, { 0.878158347494489m, 0.634048960231399m, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Decimal[,] { { 0.576307391782287m, 0.864752533695453m, }, { 0.51092677600323m, 0.2893799991027m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Decimal[,] { { 0.153698278306131m, 0.507065660194156m, }, { 0.19680310302207m, 0.94524989586482m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Decimal[,] { { 0.267417380424464m, 0.798999283828539m, }, { 0.314608088416844m, 0.689426730974195m, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Decimal[,] { { 0.29592302820781m, 0.230154942460994m, }, { 0.504791059888172m, 0.168941640633704m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Decimal[,] { { 0.872952659636868m, 0.560498700131509m, }, { 0.351216397147555m, 0.0664184335584743m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Decimal[,] { { 0.905558276106132m, 0.767398144139949m, }, { 0.384172045077594m, 0.195730688753235m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.66374311131066m, 0.673343098135655m, }, { 0.81207828462106m, 0.649004950920816m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.716676802670712m, 0.745420892043331m, }, { 0.656348488014254m, 0.854736236793549m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Decimal[,] { { 0.624314814287059m, 0.314073675531364m, }, { 0.953521053957426m, 0.968439653430673m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.464734137904023m, 0.139968893379024m, }, { 0.261070308266824m, 0.922874955142004m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Decimal[,] { { 0.571195022654953m, 0.757872331107455m, }, { 0.302360002074197m, 0.0532280521078293m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Decimal[,] { { 0.0687007906036151m, 0.788620831166719m, }, { 0.872775464869848m, 0.850480719865341m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.239888682116087m, 0.767017188420989m, }, { 0.641203091094023m, 0.553987279837692m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Decimal[,] { { 0.534979715218716m, 0.493640841890049m, }, { 0.625517506855899m, 0.149860886450049m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.12258746663194m, 0.302107753786266m, }, { 0.04262442332005m, 0.886287775090551m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Decimal[,] { { 0.826371933261816m, 0.273484080513115m, }, { 0.0204609004869588m, 0.932496628514387m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Decimal[,] { { 0.818147831151755m, 0.353340174503701m, }, { 0.405833334231868m, 0.142919888514562m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.766060516562317m, 0.718049085479578m, }, { 0.671723971494304m, 0.367588542496642m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.273203777592453m, 0.173642204259819m, }, { 0.539795952092667m, 0.641430106160689m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Decimal[,] { { 0.562043657208039m, 0.912121563898045m, }, { 0.784494992325928m, 0.354758060959242m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Decimal[,] { { 0.189293438009288m, 0.513734314226716m, }, { 0.0112646281343947m, 0.470887747614448m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Decimal[,] { { 0.550332023826778m, 0.451810802533216m, }, { 0.230410825479437m, 0.563573350207022m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.618490482494995m, 0.969395225530047m, }, { 0.462887407751845m, 0.624832514740908m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.742354107832306m, 0.239213451947059m, }, { 0.774807651119229m, 0.76629463459437m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Decimal[,] { { 0.500122783912389m, 0.42340902598714m, }, { 0.300586453424561m, 0.880639652560986m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Decimal[,] { { 0.714190220925358m, 0.204771199285393m, }, { 0.161693308275314m, 0.145787236999446m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Decimal[,] { { 0.0559760925077568m, 0.565780509102887m, }, { 0.23566509211719m, 0.161499910442573m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.967063433379036m, 0.22848406406963m, }, { 0.471348316469208m, 0.701029712515263m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.620622207666142m, 0.167349242330761m, }, { 0.0422211390358888m, 0.447953248367737m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 147,
    Value = 
new System.Decimal[,] { { 0.99174073352788m, 0.766657164977539m, }, { 0.47529774311367m, 0.839764228457858m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Decimal[,] { { 0.89666377498183m, 0.0943449570582388m, }, { 0.755051945125966m, 0.48336819308078m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Decimal[,] { { 0.441035416049859m, 0.694476504710694m, }, { 0.897595995806592m, 0.308399874169419m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.337628699743009m, 0.800996961319623m, }, { 0.854331198986841m, 0.355693411351419m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.186684737901898m, 0.597447297572213m, }, { 0.96829876968408m, 0.773027372797674m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Decimal[,] { { 0.997811466308327m, 0.96427524670027m, }, { 0.107580832911338m, 0.138462869379075m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.633053058151573m, 0.51048349546941m, }, { 0.413666042839512m, 0.0514565505624467m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Decimal[,] { { 0.641827726130198m, 0.520114793030774m, }, { 0.521509430111092m, 0.796454341979641m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Decimal[,] { { 0.643490760087728m, 0.303477070021946m, }, { 0.396727823859143m, 0.172318449276057m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.440167538759557m, 0.44839847326805m, }, { 0.0931783745522711m, 0.912226951672269m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.102158331095543m, 0.72947481719842m, }, { 0.297746695326794m, 0.182525912400158m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Decimal[,] { { 0.841882825639436m, 0.12677075162205m, }, { 0.225548343288357m, 0.997726052657328m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.325014899453045m, 0.0289833446519571m, }, { 0.1207854070295m, 0.355668022629986m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 182,
    Value = 
new System.Decimal[,] { { 0.0450961648389234m, 0.383901152922626m, }, { 0.823126224965333m, 0.178993751650406m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Decimal[,] { { 0.809729475743735m, 0.896168656185637m, }, { 0.100867442499426m, 0.107301071367623m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.645853784360984m, 0.158024866794602m, }, { 0.365490282279805m, 0.264049906988357m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.408336414305109m, 0.344244890560981m, }, { 0.862666476684861m, 0.197508061488552m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 185,
    Value = 
new System.Decimal[,] { { 0.997372363976929m, 0.508826500822022m, }, { 0.0946050988027846m, 0.52994483830889m, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1mi(
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
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
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

                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd2e1mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                System.Decimal[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.81254032466177m, 0.478703654987088m, }, { 0.629268442267919m, 0.105970481741115m, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.693587737059284m, 0.358962506255685m, }, { 0.306129654138845m, 0.425716651675119m, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.583458645433983m, 0.946497470844002m, }, { 0.963073018178216m, 0.210738993851991m, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd2e1mi_id", 
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
                System.Decimal[,] nullable = null;
                nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.861766269915668m, 0.571857198948944m, }, { 0.0164173380491022m, 0.131785305166867m, }, }));
                nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[,] nullable = null;
                nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.667865377327676m, 0.384120301670243m, }, { 0.185029204856948m, 0.79174601808175m, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD2E1M> models = null;

                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD2E1M> models = null;

                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 14;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 152, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 84, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 133, query1, 174, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 166, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 130, query1, 130, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 174, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 92, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 166);
                var models =  ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MI),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMMArrayD2E1M),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
FROM public.binary_decimalnumericmmarrayd2e1m m
LEFT JOIN public.binary_decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models =  ((IDecimalMArraynumericMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI), typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models1 = new List<DecimalnumericMMArrayD2E1MI>();
                var models2 = new List<DecimalnumericMMArrayD2E1MI>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MI>();
                var models2 = new List<DecimalnumericMMArrayD2E1MI>();
                ((IDecimalMArraynumericMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

