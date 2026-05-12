

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
    internal partial interface IDoubleMArraydouble_precisionMMArrayD2
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMMArrayD2 : IDoubleMArraydouble_precisionMMArrayD2
    {


#region TestData

        private readonly Doubledouble_precisionMMArrayD2E1M[] _testData = new Doubledouble_precisionMMArrayD2E1M[]
        {
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 4,
    Value = 
new System.Double[,] { { 0.4849049868520874d, 0.14982711815101135d, }, { 0.9146688193463579d, 0.8759851391379117d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.46830127084365447d, 0.6618579904586532d, }, { 0.41855195495392217d, 0.7019817349056405d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 7,
    Value = 
new System.Double[,] { { 0.7111356672569337d, 0.2987564605255463d, }, { 0.28021241082338477d, 0.9772735771378261d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Double[,] { { 0.16904595034554093d, 0.8762077110441286d, }, { 0.4421179511429185d, 0.44272429659708845d, }, },
    NullableValue = 
new System.Double[,] { { 0.28619285987341925d, 0.7942075213830707d, }, { 0.986223775354847d, 0.3574580229197093d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.8799627136332513d, 0.7689760722536304d, }, { 0.704983090183741d, 0.2372901194272693d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Double[,] { { 0.6751014852745046d, 0.11959444848479905d, }, { 0.09898508252564642d, 0.9662183438547185d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Double[,] { { 0.7929316390089207d, 0.7441574396869556d, }, { 0.09580167678773144d, 0.5586023686042932d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Double[,] { { 0.4352857592788433d, 0.16672566163167535d, }, { 0.22308185735196218d, 0.0686713217640672d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Double[,] { { 0.143417695952198d, 0.793710065964891d, }, { 0.6934149422787406d, 0.6314297691341254d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.9180860945835715d, 0.9433280442278531d, }, { 0.23809169622909776d, 0.2764844019269651d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Double[,] { { 0.1542940939237052d, 0.7802261571379486d, }, { 0.671001270859733d, 0.27301932598072165d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Double[,] { { 0.24087134477265715d, 0.7330578742162189d, }, { 0.026375021141712418d, 0.009187256700387558d, }, },
    NullableValue = 
new System.Double[,] { { 0.6983992894997774d, 0.8905405935549229d, }, { 0.44281568598287524d, 0.3887211051194819d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Double[,] { { 0.2064981892717377d, 0.6101905245526449d, }, { 0.37150934737360775d, 0.42550456205655907d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Double[,] { { 0.9156100409985348d, 0.7500607897751571d, }, { 0.043301764219782046d, 0.8415585162309385d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Double[,] { { 0.3155236891666411d, 0.4339008577550746d, }, { 0.28458567508592225d, 0.6872088677973022d, }, },
    NullableValue = 
new System.Double[,] { { 0.9690091502395487d, 0.6665359797750406d, }, { 0.3066906687456775d, 0.4334180493464542d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.9509491607179666d, 0.515431824433215d, }, { 0.5748971642054495d, 0.4269968622192457d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Double[,] { { 0.2606082824691416d, 0.28136179023646635d, }, { 0.39387986447017176d, 0.22947545820492965d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.2680844890325078d, 0.8735430372190743d, }, { 0.9369273398980626d, 0.2404429495428193d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Double[,] { { 0.7407652071113636d, 0.5891292165237302d, }, { 0.44979775929251975d, 0.5475835279259527d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Double[,] { { 0.5990143703567686d, 0.4956645550672596d, }, { 0.764094691762163d, 0.6238541614792907d, }, },
    NullableValue = 
new System.Double[,] { { 0.9031504411042327d, 0.5308701821680034d, }, { 0.7071876334071557d, 0.783042033562644d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.008194314565481031d, 0.8077768148203516d, }, { 0.42317079804888247d, 0.8631682635430129d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Double[,] { { 0.8573295972315738d, 0.8920017442598442d, }, { 0.2302557777427856d, 0.33127880355908024d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.2115290610363465d, 0.02183079952885303d, }, { 0.6453984128891186d, 0.9502934908723135d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Double[,] { { 0.6465157539242169d, 0.5575490951044195d, }, { 0.15345142987621962d, 0.18309322341808998d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Double[,] { { 0.3848256997495869d, 0.35973946889023856d, }, { 0.6348101700237416d, 0.8984891276908463d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.22122181608227842d, 0.44303081711054093d, }, { 0.6745389997805225d, 0.6812567751449481d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Double[,] { { 0.17197295134419044d, 0.0047944849713642546d, }, { 0.8540690122390214d, 0.2730443697381626d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.01867805955086599d, 0.7023451852567437d, }, { 0.5424479222577618d, 0.20034377720408858d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Double[,] { { 0.3543730294783971d, 0.30537642106646556d, }, { 0.507408748595658d, 0.5036609030694605d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Double[,] { { 0.018960620827807473d, 0.8592302689549021d, }, { 0.9683493258763308d, 0.4516260756635596d, }, },
    NullableValue = 
new System.Double[,] { { 0.2308238089518736d, 0.5820268842587994d, }, { 0.6365753954498471d, 0.6422181902571881d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.0921868442413789d, 0.7555999334958122d, }, { 0.8001499301538879d, 0.9385210788924249d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Double[,] { { 0.08649039892933408d, 0.07689884595350749d, }, { 0.1994028907563311d, 0.2835567268142428d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Double[,] { { 0.6220945963460495d, 0.43613655462768985d, }, { 0.6194630808530841d, 0.9775979367617423d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Double[,] { { 0.33309120933981695d, 0.29534390206522454d, }, { 0.6339056415274584d, 0.38542382024179533d, }, },
    NullableValue = 
new System.Double[,] { { 0.7187409742996378d, 0.7815308200541663d, }, { 0.5421966730312862d, 0.9762369877058925d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Double[,] { { 0.09129967976686837d, 0.8230446442825523d, }, { 0.7922816839276999d, 0.24475787166117147d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Double[,] { { 0.5480194197829692d, 0.7567376399355787d, }, { 0.2812526958411471d, 0.666228426432102d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Double[,] { { 0.45257843359514416d, 0.8151993920478814d, }, { 0.18760854700677088d, 0.3622044102482308d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.4337872357551843d, 0.8822697636299139d, }, { 0.36486322975909224d, 0.5481761188605554d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Double[,] { { 0.24781724881459943d, 0.6543163392968212d, }, { 0.25629524107196977d, 0.7279107881088928d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.3931342456099204d, 0.7593050902369561d, }, { 0.43978468093749257d, 0.40053837709092255d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Double[,] { { 0.6939549916703435d, 0.17990632378373184d, }, { 0.14729318276132597d, 0.5494108485192425d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Double[,] { { 0.04049049350105738d, 0.20806586876469257d, }, { 0.1672983181931399d, 0.19428698337293304d, }, },
    NullableValue = 
new System.Double[,] { { 0.7601810438370088d, 0.3218087028349236d, }, { 0.4672976420729127d, 0.48998048189115695d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Double[,] { { 0.43148823384696067d, 0.008930162264705777d, }, { 0.2287773135090455d, 0.7885982252719625d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Double[,] { { 0.536989178373374d, 0.24898765759204455d, }, { 0.07123213948646401d, 0.9054335524687909d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Double[,] { { 0.4758169524199678d, 0.38316753962011174d, }, { 0.2513542898428939d, 0.09126729016577062d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Double[,] { { 0.7834437522790516d, 0.724106448974502d, }, { 0.131387532542368d, 0.9832972137239311d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Double[,] { { 0.4719122561331348d, 0.37801586204438864d, }, { 0.5582492112140689d, 0.8280790088667396d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Double[,] { { 0.8470329661427513d, 0.5290399372995042d, }, { 0.46012314462312476d, 0.44734634836587905d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.8792158438613025d, 0.8908006610401622d, }, { 0.6124607533614991d, 0.30742470087707086d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Double[,] { { 0.6037341545958838d, 0.6737670455447917d, }, { 0.6662655882918649d, 0.8954694854953659d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Double[,] { { 0.4499573848414742d, 0.946022437753912d, }, { 0.23278700586912582d, 0.1224249735136953d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Double[,] { { 0.6060500067762977d, 0.32188279361034666d, }, { 0.29632468093145936d, 0.7697011108748218d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.5130459940220897d, 0.5800869993921357d, }, { 0.1364321903479101d, 0.16515472230910755d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Double[,] { { 0.5520478291458705d, 0.12541360146584835d, }, { 0.16329315611815198d, 0.46071608642678674d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Double[,] { { 0.2649601822115114d, 0.5489993412192863d, }, { 0.3820052103719932d, 0.3291280954173452d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Double[,] { { 0.08445667280600688d, 0.049279688751617035d, }, { 0.5510818375195664d, 0.2195312177491121d, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Double[,] { { 0.5071816910185727d, 0.14790136811010046d, }, { 0.3203036232152119d, 0.14384968343732962d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.6473486338398348d, 0.5251174204801698d, }, { 0.08845962539987506d, 0.5203032415849825d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Double[,] { { 0.40441758286970264d, 0.07967808321966552d, }, { 0.43391623482281694d, 0.27729656903586675d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Double[,] { { 0.778084919720656d, 0.34341953976341266d, }, { 0.8122940642641168d, 0.8077086140706407d, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Double[,] { { 0.7766695395514804d, 0.5542877148838437d, }, { 0.8689547700287d, 0.5684928113132541d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Double[,] { { 0.1053277921580642d, 0.08087329805822441d, }, { 0.12364109422757463d, 0.9412657388356082d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.39214908739171117d, 0.9372848700652293d, }, { 0.06431454643711076d, 0.19347349156432614d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Double[,] { { 0.6613824231730003d, 0.8362982384708242d, }, { 0.8598500251134681d, 0.798548843942344d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Double[,] { { 0.9529285650761107d, 0.9352039855334074d, }, { 0.7959451192817774d, 0.9230135576247291d, }, },
    NullableValue = 
new System.Double[,] { { 0.09248367780783529d, 0.0015057195871855944d, }, { 0.3053689414946291d, 0.7537800850767371d, }, },
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Double[,] { { 0.3032208320322842d, 0.8547854025017976d, }, { 0.7011798879273988d, 0.058568368181076136d, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Double[,] { { 0.9286016980090182d, 0.5733916723946325d, }, { 0.8007842418829907d, 0.7012479426023592d, }, },
    ModelInner = new Doubledouble_precisionMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Double[,] { { 0.13174709793626704d, 0.2717898311632353d, }, { 0.14836228441219146d, 0.9776853063248898d, }, },
    NullableValue = 
new System.Double[,] { { 0.968435166843966d, 0.40725553357440447d, }, { 0.6839947050475182d, 0.16504405807774725d, }, },
},
    NullableValue = 
new System.Double[,] { { 0.8426995195891822d, 0.4961063055648287d, }, { 0.21859416561213008d, 0.5183830915851003d, }, },
},
            new Doubledouble_precisionMMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Double[,] { { 0.7972912401364226d, 0.8591399429982193d, }, { 0.5878697090254539d, 0.439050448989873d, }, },
    ModelInner = null,
    NullableValue = 
new System.Double[,] { { 0.28603343336986553d, 0.5735051744260746d, }, { 0.6587192271344506d, 0.28121947985430207d, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
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

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd2e1mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                System.Double[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.9180860945835715d, 0.9433280442278531d, }, { 0.23809169622909776d, 0.2764844019269651d, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[,]>();
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.9509491607179666d, 0.515431824433215d, }, { 0.5748971642054495d, 0.4269968622192457d, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd2e1mi_id
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
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd2e1mi_id", 
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
                System.Double[,] nullable = null;
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.2680844890325078d, 0.8735430372190743d, }, { 0.9369273398980626d, 0.2404429495428193d, }, }));
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.008194314565481031d, 0.8077768148203516d, }, { 0.42317079804888247d, 0.8631682635430129d, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[,] nullable = null;
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.2115290610363465d, 0.02183079952885303d, }, { 0.6453984128891186d, 0.9502934908723135d, }, }));
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[,] { { 0.22122181608227842d, 0.44303081711054093d, }, { 0.6745389997805225d, 0.6812567751449481d, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD2E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD2E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M), typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 4, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 111, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 136, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 154, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
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
FROM public.doubledouble_precisionmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD2E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 98, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 124, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 154, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 154);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                Doubledouble_precisionMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MI),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMMArrayD2E1M),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
FROM public.binary_doubledouble_precisionmmarrayd2e1m m
LEFT JOIN public.binary_doubledouble_precisionmmarrayd2e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models =  ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
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
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI), typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MI>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA), typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD2E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD2))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

