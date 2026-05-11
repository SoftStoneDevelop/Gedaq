

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
new System.Decimal[,] { { 0.554837438889583m, 0.690486595870719m, }, { 0.0283616887150758m, 0.517281559780247m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.46767912022575m, 0.46650624031873m, }, { 0.663109039241648m, 0.279342017838965m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Decimal[,] { { 0.946418530964454m, 0.271775775164979m, }, { 0.033923719314994m, 0.398082093451702m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Decimal[,] { { 0.516467417798182m, 0.52129266720853m, }, { 0.710098301999195m, 0.650258827612741m, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Decimal[,] { { 0.822204048496092m, 0.114950290304309m, }, { 0.540335544025538m, 0.779365325448648m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.743424248567197m, 0.565314894740254m, }, { 0.0243607733982396m, 0.0474125515575209m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Decimal[,] { { 0.851768880198281m, 0.140365024482821m, }, { 0.524120576287539m, 0.551236907318513m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Decimal[,] { { 0.256317721577844m, 0.468216927279168m, }, { 0.065325155513292m, 0.483350336389126m, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Decimal[,] { { 0.554031961261113m, 0.498021010051517m, }, { 0.191934883312162m, 0.742037880072156m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.821062575956874m, 0.585357102274588m, }, { 0.975398651259839m, 0.509172241907931m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Decimal[,] { { 0.180246496472768m, 0.00461155677222991m, }, { 0.210287543337296m, 0.0843387050771005m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Decimal[,] { { 0.847598572083518m, 0.871189346764015m, }, { 0.407231852722505m, 0.798642425645388m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.399123052486072m, 0.584843490249972m, }, { 0.0778797126668346m, 0.14580859803744m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.0260486094057746m, 0.751743608659658m, }, { 0.146356847597676m, 0.699782388111449m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Decimal[,] { { 0.745336462996258m, 0.851619582624285m, }, { 0.720187550203958m, 0.33879985438964m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Decimal[,] { { 0.271598022943069m, 0.664048460723687m, }, { 0.245540681780894m, 0.809178128428046m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Decimal[,] { { 0.375220055357434m, 0.00733931142236455m, }, { 0.480228708271211m, 0.823321970402486m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.05385465261548m, 0.193468968437077m, }, { 0.913819599335912m, 0.896506716960052m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Decimal[,] { { 0.549576096411774m, 0.534553095236123m, }, { 0.126079292320839m, 0.2494459258474m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.998788792885762m, 0.727544168287804m, }, { 0.604507729750252m, 0.459016621934173m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Decimal[,] { { 0.699146854856074m, 0.650841525363248m, }, { 0.730920176803803m, 0.880542164714137m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Decimal[,] { { 0.336708330056097m, 0.055690777037359m, }, { 0.683966994146364m, 0.934590620074191m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.973860387840262m, 0.521891638626258m, }, { 0.599597686055424m, 0.916181957370852m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Decimal[,] { { 0.713854903274164m, 0.381300806178857m, }, { 0.930748241810867m, 0.0825326503177661m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.512934518966611m, 0.528135160421406m, }, { 0.173043429665667m, 0.72697983862037m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Decimal[,] { { 0.837960689217639m, 0.181772445057072m, }, { 0.595870968255891m, 0.717852838343612m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Decimal[,] { { 0.865450287640749m, 0.704444210952844m, }, { 0.617930271512724m, 0.118910857888132m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.422638956656241m, 0.663522838101676m, }, { 0.45153224780132m, 0.142773657683194m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.625121962764682m, 0.455786479743742m, }, { 0.227522786343094m, 0.529422564451025m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Decimal[,] { { 0.300549112526156m, 0.81772457756134m, }, { 0.963053407073512m, 0.390524660783333m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.470384965982594m, 0.0765016927096192m, }, { 0.977202657668143m, 0.88586278321571m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Decimal[,] { { 0.980405206081954m, 0.144696680289891m, }, { 0.75743180076695m, 0.125480262042863m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Decimal[,] { { 0.395711378874466m, 0.634872724900134m, }, { 0.37460451182593m, 0.342250730355537m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.42508429983934m, 0.595387310260715m, }, { 0.424770068109451m, 0.240078589795977m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.565706040156576m, 0.23007685575201m, }, { 0.0914077689168045m, 0.719091203330242m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Decimal[,] { { 0.642115504932855m, 0.106608359632239m, }, { 0.810601893827539m, 0.51703032149504m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Decimal[,] { { 0.802678629871981m, 0.733642353817292m, }, { 0.772635921527569m, 0.0309210194252489m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Decimal[,] { { 0.986303897569392m, 0.916964874764863m, }, { 0.0716455191798833m, 0.263772195830673m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.399737720678854m, 0.325793256553966m, }, { 0.398918769388931m, 0.341045810922m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.675725127586718m, 0.177091941332991m, }, { 0.634909826379772m, 0.63067472522476m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Decimal[,] { { 0.402394651149142m, 0.0692480523372668m, }, { 0.0681116710078136m, 0.583992832874739m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.287261920870718m, 0.733732778683958m, }, { 0.577838422950326m, 0.824740903582767m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Decimal[,] { { 0.541224825976667m, 0.0627006358331806m, }, { 0.982290987421312m, 0.182323335673103m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Decimal[,] { { 0.455578726946282m, 0.847054568838069m, }, { 0.459970832683546m, 0.657490503326014m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.479614043480696m, 0.613395331377427m, }, { 0.904624881782566m, 0.8938845792706m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Decimal[,] { { 0.447075738654556m, 0.273925249918113m, }, { 0.945628403840596m, 0.288288838931546m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 112,
    Value = 
new System.Decimal[,] { { 0.487121886446026m, 0.516066571087005m, }, { 0.364655937711659m, 0.522484907455909m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Decimal[,] { { 0.90477352630661m, 0.702154889858283m, }, { 0.379795094346184m, 0.729660036807875m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.74816810433802m, 0.388641891237469m, }, { 0.900345229533748m, 0.479580512074221m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Decimal[,] { { 0.177697725587875m, 0.289923355629605m, }, { 0.0607679658936082m, 0.868303794496802m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Decimal[,] { { 0.900087130372408m, 0.405900675393845m, }, { 0.0369182178612068m, 0.347416614969393m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Decimal[,] { { 0.892178380995931m, 0.915660954346254m, }, { 0.241189025275859m, 0.160189305529358m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.114201313648632m, 0.858381551801641m, }, { 0.716247227907363m, 0.266902930972838m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Decimal[,] { { 0.639860790095758m, 0.400257487076648m, }, { 0.371213109128055m, 0.807759101845672m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.248977135209132m, 0.404377155621185m, }, { 0.519136212572938m, 0.207969239789624m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 128,
    Value = 
new System.Decimal[,] { { 0.91317312232719m, 0.963257312873186m, }, { 0.415313666262464m, 0.922208708091237m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Decimal[,] { { 0.112408265352643m, 0.329615407269271m, }, { 0.471929296255713m, 0.648313307770619m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.596370550958974m, 0.217072709470155m, }, { 0.832280534606919m, 0.43529665463853m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Decimal[,] { { 0.252118656466075m, 0.565756564904343m, }, { 0.309594346246694m, 0.204894569899779m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Decimal[,] { { 0.742972991816992m, 0.416866581691756m, }, { 0.891336503457566m, 0.871143925799716m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Decimal[,] { { 0.723866383216373m, 0.677953661567743m, }, { 0.282943357909426m, 0.630475458491504m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.428561020627235m, 0.811527671189275m, }, { 0.869154275143474m, 0.597429031587807m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.0861062916400054m, 0.143411879769404m, }, { 0.776557661877234m, 0.131740598781067m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Decimal[,] { { 0.734929163132016m, 0.362111073136669m, }, { 0.0544334540767886m, 0.514720667935327m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.646554493423606m, 0.623592203703458m, }, { 0.00995523250265529m, 0.571183422202208m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Decimal[,] { { 0.905402370023846m, 0.65735111578887m, }, { 0.874683115788083m, 0.106040440609129m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Decimal[,] { { 0.388345562352087m, 0.61203318420075m, }, { 0.554087014718437m, 0.347570184702304m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.897017436135108m, 0.0929926488544486m, }, { 0.0598124727915912m, 0.3889254888235m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Decimal[,] { { 0.0652974581233775m, 0.870275642736482m, }, { 0.924899430042079m, 0.917009211571694m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Decimal[,] { { 0.98875809041673m, 0.165535782032928m, }, { 0.571726649626736m, 0.689499422194138m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Decimal[,] { { 0.40099815876552m, 0.700527992939216m, }, { 0.758377612275822m, 0.00810771983997782m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.706133325478853m, 0.430847109169731m, }, { 0.982713827722603m, 0.480590561221478m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Decimal[,] { { 0.661013123762363m, 0.314910293536834m, }, { 0.194085484325243m, 0.401204062225372m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.267651216035964m, 0.463046630191463m, }, { 0.846471454729291m, 0.719988543559915m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Decimal[,] { { 0.138507032189964m, 0.249572047225744m, }, { 0.214431638040786m, 0.883075455469892m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Decimal[,] { { 0.75610261111502m, 0.948785693058668m, }, { 0.972160927672229m, 0.629704450693628m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.932835062173968m, 0.420620014264551m, }, { 0.0429268938494433m, 0.994212940643066m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.364630496489632m, 0.661177194406906m, }, { 0.0938997997902328m, 0.178141970239772m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Decimal[,] { { 0.883794046498532m, 0.236533207745062m, }, { 0.662898102937526m, 0.87157321065174m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.470032635211238m, 0.239247703103235m, }, { 0.522286668215495m, 0.775535657297536m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 179,
    Value = 
new System.Decimal[,] { { 0.11219043433269m, 0.912180476033896m, }, { 0.418974085239876m, 0.734544722978768m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Decimal[,] { { 0.664587071648784m, 0.676384811194944m, }, { 0.888427633114781m, 0.806378025742004m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.181736280309211m, 0.516238789699524m, }, { 0.0416588691042872m, 0.494744137124947m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 188,
    Value = 
new System.Decimal[,] { { 0.552031551661201m, 0.828753226110372m, }, { 0.110293983732915m, 0.33910236114458m, }, },
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
new System.Decimal[,] { { 0.821062575956874m, 0.585357102274588m, }, { 0.975398651259839m, 0.509172241907931m, }, }));
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
new System.Decimal[,] { { 0.0260486094057746m, 0.751743608659658m, }, { 0.146356847597676m, 0.699782388111449m, }, }));
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
                Assert.That(nullable, Is.Null);
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
new System.Decimal[,] { { 0.998788792885762m, 0.727544168287804m, }, { 0.604507729750252m, 0.459016621934173m, }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.512934518966611m, 0.528135160421406m, }, { 0.173043429665667m, 0.72697983862037m, }, }));
                nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.625121962764682m, 0.455786479743742m, }, { 0.227522786343094m, 0.529422564451025m, }, }));
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 63, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
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
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 99, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 16, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 102, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 26, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 171, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 142, 9))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 127, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models =  ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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

