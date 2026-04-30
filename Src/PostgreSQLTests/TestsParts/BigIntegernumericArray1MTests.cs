

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
    Id = 8,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2544048261282503244L),
new System.Numerics.BigInteger(5749872607048814691L),
new System.Numerics.BigInteger(9051863519056677184L),
new System.Numerics.BigInteger(3876790793895723921L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(654985598432068200L),
new System.Numerics.BigInteger(7825904478465005854L),
new System.Numerics.BigInteger(2383966238681186167L),
},
},
            new BigIntegernumericArray1M
{
    Id = 10,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9003781703304119955L),
new System.Numerics.BigInteger(8334163139370726742L),
new System.Numerics.BigInteger(8145692984293815238L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3312896838218529378L),
new System.Numerics.BigInteger(5227885458031922729L),
new System.Numerics.BigInteger(619549609964915794L),
new System.Numerics.BigInteger(7910308134793268451L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3083247585831422958L),
new System.Numerics.BigInteger(4431242815749473880L),
new System.Numerics.BigInteger(2053368385769184044L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(452962656585820003L),
new System.Numerics.BigInteger(131864692897009776L),
new System.Numerics.BigInteger(1748062768639546855L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6491147049942256251L),
new System.Numerics.BigInteger(7849500937138381147L),
new System.Numerics.BigInteger(3385203917344783807L),
},
},
            new BigIntegernumericArray1M
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9062138513627478272L),
new System.Numerics.BigInteger(5447432939750493137L),
new System.Numerics.BigInteger(1789635697283568875L),
new System.Numerics.BigInteger(4965564746467586640L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5544764286391031925L),
new System.Numerics.BigInteger(1828651178102104916L),
new System.Numerics.BigInteger(3698156818537074904L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1386721388153669135L),
new System.Numerics.BigInteger(6993186027824135530L),
new System.Numerics.BigInteger(1483211623891937533L),
new System.Numerics.BigInteger(3458602511147667330L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6422555820699772367L),
new System.Numerics.BigInteger(2637944137541295722L),
new System.Numerics.BigInteger(1055567353558388094L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1197801872220382944L),
new System.Numerics.BigInteger(7304799287051822001L),
new System.Numerics.BigInteger(3136250871775177482L),
new System.Numerics.BigInteger(3279025643889103827L),
},
},
            new BigIntegernumericArray1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5602385082853626755L),
new System.Numerics.BigInteger(19848693817782901L),
new System.Numerics.BigInteger(238670470327779211L),
new System.Numerics.BigInteger(3240591546038619457L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1503911623469433531L),
new System.Numerics.BigInteger(9060433959343921907L),
new System.Numerics.BigInteger(1449276639028444786L),
new System.Numerics.BigInteger(3937442350409453598L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6923299177468977505L),
new System.Numerics.BigInteger(6917283814449637038L),
new System.Numerics.BigInteger(3983572339120574141L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6730455350287968816L),
new System.Numerics.BigInteger(7402541162128377854L),
new System.Numerics.BigInteger(1254101516175413559L),
new System.Numerics.BigInteger(7534601051377389307L),
},
},
            new BigIntegernumericArray1M
{
    Id = 50,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6825614076102322197L),
new System.Numerics.BigInteger(1783792633705820869L),
new System.Numerics.BigInteger(2349145129069403472L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2110241720680976268L),
new System.Numerics.BigInteger(6177758179702135023L),
new System.Numerics.BigInteger(7741053378911526094L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6583118668733892749L),
new System.Numerics.BigInteger(8967390267005132351L),
new System.Numerics.BigInteger(2533873633825260888L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8547283839583346655L),
new System.Numerics.BigInteger(7825157106868822270L),
new System.Numerics.BigInteger(3822892196497422045L),
new System.Numerics.BigInteger(7579051981525047257L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7372334688784784380L),
new System.Numerics.BigInteger(2008478020937440289L),
new System.Numerics.BigInteger(7138557474795662379L),
new System.Numerics.BigInteger(5499593420640427083L),
},
},
            new BigIntegernumericArray1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5437056317362807463L),
new System.Numerics.BigInteger(468572175927960574L),
new System.Numerics.BigInteger(2767779580697491047L),
new System.Numerics.BigInteger(2782443971239837631L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1617306552654056785L),
new System.Numerics.BigInteger(3252667914201337301L),
new System.Numerics.BigInteger(7314875313484938395L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(364012917959183525L),
new System.Numerics.BigInteger(4508528157878911061L),
new System.Numerics.BigInteger(8680078982744560661L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7196091400717564696L),
new System.Numerics.BigInteger(3393183771404931253L),
new System.Numerics.BigInteger(8671917222687257341L),
new System.Numerics.BigInteger(4861349768130547958L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3566798487235469163L),
new System.Numerics.BigInteger(5126390688834088122L),
new System.Numerics.BigInteger(7373920031668301560L),
new System.Numerics.BigInteger(2572802820443295254L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9129917912490892617L),
new System.Numerics.BigInteger(3365555661996628848L),
new System.Numerics.BigInteger(8407590467079165585L),
new System.Numerics.BigInteger(8451369075259595083L),
},
},
            new BigIntegernumericArray1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2436855639752191480L),
new System.Numerics.BigInteger(3030480862826001943L),
new System.Numerics.BigInteger(2896380256089268574L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7715424198823914847L),
new System.Numerics.BigInteger(722237805617898823L),
new System.Numerics.BigInteger(7696409194011630796L),
new System.Numerics.BigInteger(4335462851774442141L),
},
},
            new BigIntegernumericArray1M
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4764147421239365861L),
new System.Numerics.BigInteger(8084119092661379614L),
new System.Numerics.BigInteger(5634827936264857983L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5940503947304445689L),
new System.Numerics.BigInteger(247723324660187727L),
new System.Numerics.BigInteger(3734427852120487681L),
new System.Numerics.BigInteger(350608238465292134L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4607415115856434478L),
new System.Numerics.BigInteger(3144546990641983627L),
new System.Numerics.BigInteger(5653292292263725217L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3122163689493815616L),
new System.Numerics.BigInteger(3982989247172670103L),
new System.Numerics.BigInteger(3033787418917830522L),
new System.Numerics.BigInteger(732217432099940804L),
},
},
            new BigIntegernumericArray1M
{
    Id = 88,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2995009165577405425L),
new System.Numerics.BigInteger(7046041345970387789L),
new System.Numerics.BigInteger(7992001629812887376L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7445683950872499502L),
new System.Numerics.BigInteger(4255254550150482468L),
new System.Numerics.BigInteger(3124895680955740519L),
},
},
            new BigIntegernumericArray1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3905546465903903217L),
new System.Numerics.BigInteger(1846898394189088259L),
new System.Numerics.BigInteger(6122618818412701961L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7114973355395327006L),
new System.Numerics.BigInteger(6169101202887962637L),
new System.Numerics.BigInteger(4361487255693877354L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2556946260246609893L),
new System.Numerics.BigInteger(8282710412804967242L),
new System.Numerics.BigInteger(6965379500816267195L),
new System.Numerics.BigInteger(370480995401053633L),
},
},
            new BigIntegernumericArray1M
{
    Id = 98,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3844052628225395835L),
new System.Numerics.BigInteger(73717737363890420L),
new System.Numerics.BigInteger(6043011462764627988L),
new System.Numerics.BigInteger(1757178592836962406L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3245980501821704421L),
new System.Numerics.BigInteger(4361732130430071335L),
new System.Numerics.BigInteger(4151603606237141187L),
new System.Numerics.BigInteger(1014698164070778864L),
},
},
            new BigIntegernumericArray1M
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8537884597270364407L),
new System.Numerics.BigInteger(2512383101467261461L),
new System.Numerics.BigInteger(5116383809482902609L),
new System.Numerics.BigInteger(7403106453639882899L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6337151480185599707L),
new System.Numerics.BigInteger(554401429718158144L),
new System.Numerics.BigInteger(1127225466590502369L),
new System.Numerics.BigInteger(6066766709941918799L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4917039804830835461L),
new System.Numerics.BigInteger(7506763512938499047L),
new System.Numerics.BigInteger(1869991103039139097L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 106,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1624609495002337169L),
new System.Numerics.BigInteger(1225558078386799278L),
new System.Numerics.BigInteger(8548042042671397064L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3586679016400371654L),
new System.Numerics.BigInteger(2770219103362032614L),
new System.Numerics.BigInteger(7616794284908746543L),
},
},
            new BigIntegernumericArray1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(441789662220318436L),
new System.Numerics.BigInteger(8495411627013875749L),
new System.Numerics.BigInteger(7436409833125593701L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8393008948111757596L),
new System.Numerics.BigInteger(5900260043525828500L),
new System.Numerics.BigInteger(1428538174080656660L),
new System.Numerics.BigInteger(4754510500834152484L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 111,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5793177206607377338L),
new System.Numerics.BigInteger(583459118102270101L),
new System.Numerics.BigInteger(3493169778547021288L),
new System.Numerics.BigInteger(1065554106832348718L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4346090128929862009L),
new System.Numerics.BigInteger(1337514395010049756L),
new System.Numerics.BigInteger(4155090719536623489L),
},
},
            new BigIntegernumericArray1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2786753227132109438L),
new System.Numerics.BigInteger(4264113613009250481L),
new System.Numerics.BigInteger(1985483097564003869L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8690501504462380889L),
new System.Numerics.BigInteger(6224801847546320279L),
new System.Numerics.BigInteger(7692953548708604849L),
new System.Numerics.BigInteger(3082799328620140237L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8342866759484745372L),
new System.Numerics.BigInteger(4757456716605087735L),
new System.Numerics.BigInteger(4446233819820523577L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 122,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5655601930464877983L),
new System.Numerics.BigInteger(2183884501233691890L),
new System.Numerics.BigInteger(1444570057981060623L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 127,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(608728782341963501L),
new System.Numerics.BigInteger(4571617733228304474L),
new System.Numerics.BigInteger(5931455145332941772L),
new System.Numerics.BigInteger(517249707725064257L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4525001810405439892L),
new System.Numerics.BigInteger(3830405541694354974L),
new System.Numerics.BigInteger(3559569582510296508L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(143291864606862817L),
new System.Numerics.BigInteger(1105138649097481245L),
new System.Numerics.BigInteger(7945523091546396660L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2440730221177370797L),
new System.Numerics.BigInteger(8254011155211921509L),
new System.Numerics.BigInteger(5913277795407585997L),
new System.Numerics.BigInteger(1995196050280948349L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 138,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3692262074058719575L),
new System.Numerics.BigInteger(6495564233854416053L),
new System.Numerics.BigInteger(4165508716779869970L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3002645597473514960L),
new System.Numerics.BigInteger(9184764247881912677L),
new System.Numerics.BigInteger(4788034973292780315L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4455233783850356353L),
new System.Numerics.BigInteger(2284784053039265588L),
new System.Numerics.BigInteger(5652404303598891442L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2412738175957546060L),
new System.Numerics.BigInteger(4309260614759369274L),
new System.Numerics.BigInteger(5252613398878409469L),
},
},
            new BigIntegernumericArray1M
{
    Id = 141,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2090998153690781495L),
new System.Numerics.BigInteger(648993269599265541L),
new System.Numerics.BigInteger(5666342724080193845L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 144,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(403560392929096902L),
new System.Numerics.BigInteger(4141098031441761616L),
new System.Numerics.BigInteger(503563911588250226L),
new System.Numerics.BigInteger(9024956206981406538L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6713960112105393971L),
new System.Numerics.BigInteger(8932844625178594660L),
new System.Numerics.BigInteger(7023024812231184478L),
new System.Numerics.BigInteger(3622776710182788081L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7071570640452297871L),
new System.Numerics.BigInteger(4775068674834507176L),
new System.Numerics.BigInteger(9111220341562776181L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 152,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(875366933272760877L),
new System.Numerics.BigInteger(3938816619145765396L),
new System.Numerics.BigInteger(4260004985027668648L),
new System.Numerics.BigInteger(3222842077703725666L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 157,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(657161803218907644L),
new System.Numerics.BigInteger(370153427986552961L),
new System.Numerics.BigInteger(1997791485196518815L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1097829066790461091L),
new System.Numerics.BigInteger(1974230059209657358L),
new System.Numerics.BigInteger(6562844407928203071L),
},
    NullableValue = null,
},
    NullableValue = null,
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM public.bigintegernumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.bigintegernumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 88;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[29], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 111, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 10, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 106, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 28, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 53, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 98, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 25, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
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
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
BigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
BigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(BigIntegernumericArray1MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(BigIntegernumericArray1M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

