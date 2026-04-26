

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region TestData

        private readonly BigIntegernumericArray1M[] _testData = new BigIntegernumericArray1M[]
        {
            new BigIntegernumericArray1M
{
    Id = 2,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2272743248172164799L),
new System.Numerics.BigInteger(338571392718783410L),
new System.Numerics.BigInteger(4675300504083002517L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 4,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1546204935421118754L),
new System.Numerics.BigInteger(1552168475232341051L),
new System.Numerics.BigInteger(8309463842011305398L),
new System.Numerics.BigInteger(3042865682499757332L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 1,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5154881307811927200L),
new System.Numerics.BigInteger(3042511972017859902L),
new System.Numerics.BigInteger(8590167186777769071L),
new System.Numerics.BigInteger(5542912801881408960L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6998168640103696518L),
new System.Numerics.BigInteger(8731243961800487052L),
new System.Numerics.BigInteger(217077905594131544L),
},
},
            new BigIntegernumericArray1M
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7902724372742671781L),
new System.Numerics.BigInteger(2992416054463881607L),
new System.Numerics.BigInteger(4965106431846516777L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(162879282133677303L),
new System.Numerics.BigInteger(142956171518875581L),
new System.Numerics.BigInteger(3269323879682381109L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 10,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3566112491536471130L),
new System.Numerics.BigInteger(6719840154502914752L),
new System.Numerics.BigInteger(1520601331958631224L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8529302350037983091L),
new System.Numerics.BigInteger(4057194353140391820L),
new System.Numerics.BigInteger(4967956355226805258L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7805554786795862176L),
new System.Numerics.BigInteger(5288289532485281890L),
new System.Numerics.BigInteger(199363227760116071L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3453892977181490768L),
new System.Numerics.BigInteger(3740215086999266060L),
new System.Numerics.BigInteger(2832502009443631507L),
new System.Numerics.BigInteger(4066736468712550408L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6758157719908416762L),
new System.Numerics.BigInteger(2440456021156360239L),
new System.Numerics.BigInteger(7701498429380606162L),
new System.Numerics.BigInteger(8129408783321209518L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(77280128798891833L),
new System.Numerics.BigInteger(8230220385263439183L),
new System.Numerics.BigInteger(1385252081048544442L),
},
},
            new BigIntegernumericArray1M
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4834860405985926057L),
new System.Numerics.BigInteger(5177115025692376671L),
new System.Numerics.BigInteger(347026946774300889L),
new System.Numerics.BigInteger(7502400725520348697L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8246962169280311876L),
new System.Numerics.BigInteger(872635295542682688L),
new System.Numerics.BigInteger(8650487611835216463L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2138564705887027259L),
new System.Numerics.BigInteger(5276316032642552933L),
new System.Numerics.BigInteger(74654153851844458L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4687617286783484768L),
new System.Numerics.BigInteger(2739131984589484136L),
new System.Numerics.BigInteger(2033535460560463013L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3096543940485092135L),
new System.Numerics.BigInteger(3311937192103380029L),
new System.Numerics.BigInteger(5209742643015924879L),
new System.Numerics.BigInteger(3545206659091089487L),
},
},
            new BigIntegernumericArray1M
{
    Id = 33,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4325259278204363090L),
new System.Numerics.BigInteger(8789344050672993304L),
new System.Numerics.BigInteger(4765313947907356213L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6075329198710472504L),
new System.Numerics.BigInteger(940052149013040876L),
new System.Numerics.BigInteger(6186310560607848012L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2655424453186908185L),
new System.Numerics.BigInteger(3932296668576759014L),
new System.Numerics.BigInteger(7464044421196117259L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6097924477037073641L),
new System.Numerics.BigInteger(4155311429115603861L),
new System.Numerics.BigInteger(6391543359399782571L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2758277367010700117L),
new System.Numerics.BigInteger(4524957185284557755L),
new System.Numerics.BigInteger(7364477853148337518L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(153210947979053307L),
new System.Numerics.BigInteger(5419756837554664973L),
new System.Numerics.BigInteger(1503949972273907952L),
},
},
            new BigIntegernumericArray1M
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1189735546245003452L),
new System.Numerics.BigInteger(2626677494280352785L),
new System.Numerics.BigInteger(1710306848818016611L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5451430402088616070L),
new System.Numerics.BigInteger(4209772541172795980L),
new System.Numerics.BigInteger(5018024727793159314L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6590704954405783131L),
new System.Numerics.BigInteger(827992592335976024L),
new System.Numerics.BigInteger(4784588189291308532L),
},
},
            new BigIntegernumericArray1M
{
    Id = 57,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6357040238451782607L),
new System.Numerics.BigInteger(9221300053726439244L),
new System.Numerics.BigInteger(2096246628746216015L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2649742887752204144L),
new System.Numerics.BigInteger(3626060457492784326L),
new System.Numerics.BigInteger(6276105360650734902L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5622599677845045009L),
new System.Numerics.BigInteger(9083212318594399947L),
new System.Numerics.BigInteger(847940479745317989L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5413967976125080607L),
new System.Numerics.BigInteger(5779581958510388642L),
new System.Numerics.BigInteger(6368699283247805098L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 74,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5519978653570937868L),
new System.Numerics.BigInteger(2604163444077351162L),
new System.Numerics.BigInteger(1345530351426524749L),
new System.Numerics.BigInteger(7226530068308205363L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8704880221793609254L),
new System.Numerics.BigInteger(4724853400079063121L),
new System.Numerics.BigInteger(5734557740841265194L),
new System.Numerics.BigInteger(2606995407597830339L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4148151078883466957L),
new System.Numerics.BigInteger(1079147283493742577L),
new System.Numerics.BigInteger(7426242705739965383L),
},
},
            new BigIntegernumericArray1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7195583011748150533L),
new System.Numerics.BigInteger(2398479136742888266L),
new System.Numerics.BigInteger(2487827525927114204L),
new System.Numerics.BigInteger(1588446480874107076L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3199184379035435258L),
new System.Numerics.BigInteger(782010012725494896L),
new System.Numerics.BigInteger(9130788321491014919L),
new System.Numerics.BigInteger(1402617120381672455L),
},
},
            new BigIntegernumericArray1M
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(925956369399874159L),
new System.Numerics.BigInteger(9129170854643949833L),
new System.Numerics.BigInteger(2067806668090184293L),
new System.Numerics.BigInteger(8688537395152495671L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2523972829888729171L),
new System.Numerics.BigInteger(8870560070433073600L),
new System.Numerics.BigInteger(4026290392198381286L),
new System.Numerics.BigInteger(3978751892946282399L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(91810247827651721L),
new System.Numerics.BigInteger(9181911606989520950L),
new System.Numerics.BigInteger(6785436640142376784L),
},
},
            new BigIntegernumericArray1M
{
    Id = 86,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7600569771334130177L),
new System.Numerics.BigInteger(2637825519649870419L),
new System.Numerics.BigInteger(7846135629699343630L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4638263857593362109L),
new System.Numerics.BigInteger(8817815939820207367L),
new System.Numerics.BigInteger(681951314859241685L),
},
},
            new BigIntegernumericArray1M
{
    Id = 93,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8187241438663386936L),
new System.Numerics.BigInteger(490706100649089402L),
new System.Numerics.BigInteger(665189622908956820L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1225412731470362013L),
new System.Numerics.BigInteger(7251451988985846174L),
new System.Numerics.BigInteger(1429763586223062058L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 101,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2899090951345710981L),
new System.Numerics.BigInteger(6801879746206641363L),
new System.Numerics.BigInteger(3721084687016256383L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1874011095129382556L),
new System.Numerics.BigInteger(5627672022585173449L),
new System.Numerics.BigInteger(3509929222356823205L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3164003766145767595L),
new System.Numerics.BigInteger(7771933258376801726L),
new System.Numerics.BigInteger(7128140790199707298L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8030374356762922658L),
new System.Numerics.BigInteger(6987813899754998863L),
new System.Numerics.BigInteger(2573236418797635273L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2408787530056747401L),
new System.Numerics.BigInteger(6628259870262957761L),
new System.Numerics.BigInteger(6958498309711815510L),
new System.Numerics.BigInteger(2595512539672352335L),
},
},
            new BigIntegernumericArray1M
{
    Id = 112,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(729305870193494017L),
new System.Numerics.BigInteger(3113227988380634959L),
new System.Numerics.BigInteger(7062526928006925950L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5009805956166377446L),
new System.Numerics.BigInteger(4937687586254678918L),
new System.Numerics.BigInteger(7485316013499705220L),
},
},
            new BigIntegernumericArray1M
{
    Id = 114,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1824824382274439358L),
new System.Numerics.BigInteger(3085186917972799275L),
new System.Numerics.BigInteger(4993298782457406447L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 50,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2745672635630086982L),
new System.Numerics.BigInteger(525904326664986235L),
new System.Numerics.BigInteger(1329695874335695114L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8466369551578162397L),
new System.Numerics.BigInteger(7114672662505524731L),
new System.Numerics.BigInteger(2760146514212874255L),
new System.Numerics.BigInteger(7911127204001465000L),
},
},
            new BigIntegernumericArray1M
{
    Id = 116,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(251712936042871541L),
new System.Numerics.BigInteger(5205205045816378601L),
new System.Numerics.BigInteger(9123435889288981621L),
new System.Numerics.BigInteger(4011583590190675566L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7990072153507856193L),
new System.Numerics.BigInteger(1741407956603861679L),
new System.Numerics.BigInteger(7562535226750355043L),
new System.Numerics.BigInteger(8732807342593887692L),
},
},
            new BigIntegernumericArray1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2361622304437455021L),
new System.Numerics.BigInteger(1916063371336586458L),
new System.Numerics.BigInteger(6573336135652266980L),
new System.Numerics.BigInteger(7812581272609184072L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 51,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7414343324854320886L),
new System.Numerics.BigInteger(8023706022895303625L),
new System.Numerics.BigInteger(8310489719440848135L),
new System.Numerics.BigInteger(4570040107682862323L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6263669517528774975L),
new System.Numerics.BigInteger(9037275565995363273L),
new System.Numerics.BigInteger(1756994142073239375L),
new System.Numerics.BigInteger(1976449980055417479L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8496042686001680831L),
new System.Numerics.BigInteger(9105641549413294098L),
new System.Numerics.BigInteger(1290551438295736353L),
new System.Numerics.BigInteger(668727201448688566L),
},
},
            new BigIntegernumericArray1M
{
    Id = 127,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1004147883969963444L),
new System.Numerics.BigInteger(3083292198050321667L),
new System.Numerics.BigInteger(8230760295151294225L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 135,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2391255740714917446L),
new System.Numerics.BigInteger(6498805633551237984L),
new System.Numerics.BigInteger(1958298481525275500L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7622742281614030285L),
new System.Numerics.BigInteger(897278449481329700L),
new System.Numerics.BigInteger(1306139776653432616L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3153682910140753538L),
new System.Numerics.BigInteger(6714732892590620475L),
new System.Numerics.BigInteger(1403916725834571692L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2209560921662007065L),
new System.Numerics.BigInteger(3068120495510846171L),
new System.Numerics.BigInteger(2137766292097261948L),
new System.Numerics.BigInteger(5351564805326971178L),
},
},
            new BigIntegernumericArray1M
{
    Id = 142,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6119244352509468644L),
new System.Numerics.BigInteger(1004877828639983623L),
new System.Numerics.BigInteger(6111060603302893332L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 148,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4105426471480827661L),
new System.Numerics.BigInteger(1279279226209257482L),
new System.Numerics.BigInteger(459473682214549698L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 58,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7751108194865938826L),
new System.Numerics.BigInteger(3234282655878997407L),
new System.Numerics.BigInteger(2871800644927259122L),
new System.Numerics.BigInteger(573959964187119956L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1419467902261331326L),
new System.Numerics.BigInteger(454648569449454357L),
new System.Numerics.BigInteger(2718823362474240234L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9101439186714999716L),
new System.Numerics.BigInteger(6884949961895868305L),
new System.Numerics.BigInteger(4477191809497346103L),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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

                var models = await ((IBigIntegerArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
BigIntegernumericArray1M.AssertModel(models[0],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
BigIntegernumericArray1M.AssertModel(models[0],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[29], false);
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

                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
BigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 28, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatchAsync(connection, 33, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
BigIntegernumericArray1M.AssertModel(models[0],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[29], false);
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
                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatch(connection, 75, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
BigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
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
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
BigIntegernumericArray1M.AssertModel(models[0],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
BigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray1M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray1M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray1M.AssertModel(models[14],_testData[14], false);
                BigIntegernumericArray1M.AssertModel(models[15],_testData[15], false);
                BigIntegernumericArray1M.AssertModel(models[16],_testData[16], false);
                BigIntegernumericArray1M.AssertModel(models[17],_testData[17], false);
                BigIntegernumericArray1M.AssertModel(models[18],_testData[18], false);
                BigIntegernumericArray1M.AssertModel(models[19],_testData[19], false);
                BigIntegernumericArray1M.AssertModel(models[20],_testData[20], false);
                BigIntegernumericArray1M.AssertModel(models[21],_testData[21], false);
                BigIntegernumericArray1M.AssertModel(models[22],_testData[22], false);
                BigIntegernumericArray1M.AssertModel(models[23],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[24],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[25],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[26],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[27],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[28],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

