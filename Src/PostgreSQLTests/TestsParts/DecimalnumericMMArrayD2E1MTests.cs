

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
    Id = 6,
    Value = 
new System.Decimal[,] { { 0.467100568144889m, 0.611358272750037m, }, { 0.938966027912272m, 0.644179167991672m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Decimal[,] { { 0.318899487987754m, 0.464374819292743m, }, { 0.2755071176684m, 0.877692538025423m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Decimal[,] { { 0.493086345249157m, 0.555688816771283m, }, { 0.351711536238963m, 0.784542664367716m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.596550591582508m, 0.649785063892945m, }, { 0.423756893644138m, 0.11516501661451m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.45497545724618m, 0.39095067675391m, }, { 0.174441924758552m, 0.178891470098942m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Decimal[,] { { 0.558374206778693m, 0.260357204936353m, }, { 0.961985252420041m, 0.0381345519312813m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.963179699959554m, 0.875745214518212m, }, { 0.922711513826194m, 0.156973710427988m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Decimal[,] { { 0.637402371323805m, 0.63884382363796m, }, { 0.953949192710641m, 0.37504213431649m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 5,
    Value = 
new System.Decimal[,] { { 0.950195159253798m, 0.782986697893142m, }, { 0.975457684640652m, 0.273156887467857m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.257867467783823m, 0.75338878304033m, }, { 0.102347686964986m, 0.247566145547365m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Decimal[,] { { 0.914224821275631m, 0.627930406910618m, }, { 0.81109972223246m, 0.170990546996975m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.453318853747667m, 0.296433300341421m, }, { 0.805716520078425m, 0.806578948362789m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Decimal[,] { { 0.458493523056914m, 0.0167488512739605m, }, { 0.191362742273534m, 0.688029894732586m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Decimal[,] { { 0.443077152695628m, 0.0819305435403167m, }, { 0.241284474360132m, 0.797271003209714m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.734980928236034m, 0.27613701790815m, }, { 0.469188365140091m, 0.161449638031407m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Decimal[,] { { 0.413830651391384m, 0.00339999475487285m, }, { 0.814350670111162m, 0.206260237656697m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.221851887916863m, 0.801962883524551m, }, { 0.197922041694996m, 0.0484919148587098m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Decimal[,] { { 0.207845831082128m, 0.0342157343792888m, }, { 0.364524429505321m, 0.332809016229932m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Decimal[,] { { 0.498379551580231m, 0.9493611003002m, }, { 0.424275384008359m, 0.243833063565412m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.249783824548728m, 0.682491992518868m, }, { 0.749414948506641m, 0.610500039685722m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Decimal[,] { { 0.427627525823515m, 0.964659967567617m, }, { 0.287341538560499m, 0.0408294525324938m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Decimal[,] { { 0.185244070043443m, 0.688053039055768m, }, { 0.537867067512993m, 0.863228521938017m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Decimal[,] { { 0.483627610217473m, 0.50179031952123m, }, { 0.031471319891583m, 0.208003143690117m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.145181854528445m, 0.80303753904676m, }, { 0.409182981722733m, 0.46600990224887m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Decimal[,] { { 0.701588101415359m, 0.790610590967022m, }, { 0.204361655458983m, 0.80978069196192m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.465410524125223m, 0.288851096510794m, }, { 0.304114585448487m, 0.280376886980716m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Decimal[,] { { 0.460769917965436m, 0.175907827037339m, }, { 0.673545713063011m, 0.46798515961177m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Decimal[,] { { 0.837215258083659m, 0.424423244108183m, }, { 0.865640651792413m, 0.180368055687738m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.494342474281883m, 0.682948776384993m, }, { 0.203160653649815m, 0.212811817713317m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.991414771689742m, 0.346134195150681m, }, { 0.195393646672255m, 0.75167263236912m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Decimal[,] { { 0.974628918338539m, 0.755598185978431m, }, { 0.417550094821235m, 0.368649433826104m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Decimal[,] { { 0.246086636304641m, 0.481022946966995m, }, { 0.788514452673702m, 0.993931039932094m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Decimal[,] { { 0.367133204369022m, 0.349760883578548m, }, { 0.653770338182081m, 0.99019282146593m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.136189019404808m, 0.949182661298906m, }, { 0.818738548095207m, 0.690826934227722m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.399149794110698m, 0.293544527685175m, }, { 0.9568256661594m, 0.73921074049935m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Decimal[,] { { 0.200856072099368m, 0.0447660551366528m, }, { 0.846870286926218m, 0.760821690861007m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.898449411594984m, 0.367759718358778m, }, { 0.31028607459898m, 0.369402383896935m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Decimal[,] { { 0.838398439757909m, 0.677394384172577m, }, { 0.431883544821946m, 0.285078807631463m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Decimal[,] { { 0.576153709145753m, 0.0413476831402966m, }, { 0.413088500709772m, 0.556305756109487m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.436160322679364m, 0.517362517429923m, }, { 0.249329195026202m, 0.255810613945575m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.0630185952582208m, 0.113205150264214m, }, { 0.207418812515069m, 0.759841266239396m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Decimal[,] { { 0.106165444792888m, 0.342733537303754m, }, { 0.097214243746986m, 0.245649572597599m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Decimal[,] { { 0.45136010394512m, 0.0868878988877715m, }, { 0.563998224247948m, 0.0270301120491691m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Decimal[,] { { 0.705987388664844m, 0.782468137774621m, }, { 0.107764820739754m, 0.298631105380163m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.256359077920529m, 0.132394280628359m, }, { 0.543351856122136m, 0.857180793054164m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.118941917911962m, 0.962506223136353m, }, { 0.368920844750485m, 0.057441325414486m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Decimal[,] { { 0.0704331333248746m, 0.765595309742632m, }, { 0.746423794935946m, 0.0569905225633402m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.123852102913979m, 0.155185328480126m, }, { 0.17482031552398m, 0.816432515176566m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Decimal[,] { { 0.231727316268374m, 0.914170523018681m, }, { 0.866561429875776m, 0.454357920419146m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Decimal[,] { { 0.21717333538048m, 0.541136031707024m, }, { 0.0596849775125336m, 0.221661615650006m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.552222186976784m, 0.0833010367742202m, }, { 0.170413967810318m, 0.000156156266620133m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Decimal[,] { { 0.203300311518587m, 0.566958398084453m, }, { 0.041952632407641m, 0.733167424590558m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.153174050474722m, 0.922718413737346m, }, { 0.436525526837391m, 0.572470992197858m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Decimal[,] { { 0.45543699681461m, 0.870525478540309m, }, { 0.667303237425241m, 0.570532017614732m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Decimal[,] { { 0.845562389883802m, 0.95762537067058m, }, { 0.452999358842209m, 0.355606392634109m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.516562845829601m, 0.615181368842884m, }, { 0.462060310019624m, 0.928198625331154m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.381322613883474m, 0.212383798629591m, }, { 0.00248565631331488m, 0.56523175325154m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Decimal[,] { { 0.246807108455034m, 0.0665897874485474m, }, { 0.993968787278224m, 0.976461298009823m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.413997883859661m, 0.970999457027112m, }, { 0.112629174498373m, 0.293516133045842m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Decimal[,] { { 0.57715017868355m, 0.36988544285482m, }, { 0.399966802458724m, 0.125740606487215m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Decimal[,] { { 0.396868192784597m, 0.717230735745399m, }, { 0.0932091689868557m, 0.0556799909601128m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.0948985490188884m, 0.305386443960235m, }, { 0.668375898318676m, 0.0590205086408205m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Decimal[,] { { 0.659990011434573m, 0.898695406696644m, }, { 0.779383569811306m, 0.437683521127636m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Decimal[,] { { 0.164459494424351m, 0.824055543379649m, }, { 0.375691217416238m, 0.448127417420747m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Decimal[,] { { 0.68044120125397m, 0.397018674375928m, }, { 0.510410073719467m, 0.801640398973709m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.440560557238542m, 0.264863961915067m, }, { 0.0523857072046023m, 0.012136101224249m, }, },
},
    NullableValue = 
new System.Decimal[,] { { 0.356682783650528m, 0.0188039894844333m, }, { 0.893877146073641m, 0.80773116879305m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Decimal[,] { { 0.462188232806391m, 0.365511648570715m, }, { 0.253450830030653m, 0.182879487277644m, }, },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Decimal[,] { { 0.929241194217771m, 0.593183699598213m, }, { 0.664047951922821m, 0.425277735852586m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Decimal[,] { { 0.673963918027641m, 0.678095891158656m, }, { 0.156438228791446m, 0.839092713206352m, }, },
    NullableValue = 
new System.Decimal[,] { { 0.410026930135552m, 0.696339728921327m, }, { 0.0278348508182763m, 0.959143642759849m, }, },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Decimal[,] { { 0.403904639006518m, 0.436367055747624m, }, { 0.234193256985219m, 0.460916481169874m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.0402775612888863m, 0.477783608598299m, }, { 0.750382125935386m, 0.0877819366010245m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 139,
    Value = 
new System.Decimal[,] { { 0.132652890101947m, 0.218634521190612m, }, { 0.402181966230052m, 0.829777660278859m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Decimal[,] { { 0.136935160534774m, 0.714595176763315m, }, { 0.0520752536288488m, 0.135083922487407m, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Decimal[,] { { 0.769494281056275m, 0.380454209498366m, }, { 0.590059281006066m, 0.402234588857195m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.104886009117725m, 0.450955209037335m, }, { 0.678507961303306m, 0.711934410476099m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Decimal[,] { { 0.65348502797508m, 0.93058617514559m, }, { 0.343956764317894m, 0.359908668619335m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Decimal[,] { { 0.561928408973554m, 0.100312368377555m, }, { 0.946205676782668m, 0.670295052061104m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.802774309720179m, 0.808911412332348m, }, { 0.884950609542394m, 0.946659550666212m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Decimal[,] { { 0.0283297972187297m, 0.702376095236808m, }, { 0.229236036474746m, 0.507287412412938m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.21045855170229m, 0.233146043951845m, }, { 0.469804941703332m, 0.789644526064653m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Decimal[,] { { 0.250003009237069m, 0.743825198508845m, }, { 0.748691829097869m, 0.591470643645466m, }, },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Decimal[,] { { 0.15828448363379m, 0.187817961712192m, }, { 0.367956696977621m, 0.651604231481052m, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { { 0.966756863640023m, 0.536145951625353m, }, { 0.0346975893581645m, 0.713803381241602m, }, },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Decimal[,] { { 0.408284277987429m, 0.524178107724868m, }, { 0.660498501490518m, 0.0661318208826014m, }, },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { { 0.0808563449583303m, 0.992588853688889m, }, { 0.717568861098838m, 0.816899684631131m, }, },
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
new System.Decimal[,] { { 0.453318853747667m, 0.296433300341421m, }, { 0.805716520078425m, 0.806578948362789m, }, }));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.221851887916863m, 0.801962883524551m, }, { 0.197922041694996m, 0.0484919148587098m, }, }));
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
new System.Decimal[,] { { 0.249783824548728m, 0.682491992518868m, }, { 0.749414948506641m, 0.610500039685722m, }, }));
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
                Assert.That(nullable, Is.Null);
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
new System.Decimal[,] { { 0.465410524125223m, 0.288851096510794m, }, { 0.304114585448487m, 0.280376886980716m, }, }));
                nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { { 0.991414771689742m, 0.346134195150681m, }, { 0.195393646672255m, 0.75167263236912m, }, }));
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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

                    if(resultIndex == 2)
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 143, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 129, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 53, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 98, query1, 82, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 98, query1, 90, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 102, query1, 149, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 60))
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 85, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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

