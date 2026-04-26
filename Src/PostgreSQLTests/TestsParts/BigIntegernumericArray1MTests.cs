

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
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4483449483172445044L),
new System.Numerics.BigInteger(3800715978376360088L),
new System.Numerics.BigInteger(8404031594501449314L),
new System.Numerics.BigInteger(3579516916693408050L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 4,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(977414769551385642L),
new System.Numerics.BigInteger(3619278146421881372L),
new System.Numerics.BigInteger(2688591376398355064L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 4,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4655848560246143486L),
new System.Numerics.BigInteger(2509940994582647386L),
new System.Numerics.BigInteger(3961818645135015984L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5440866919109523058L),
new System.Numerics.BigInteger(6000176587741391329L),
new System.Numerics.BigInteger(6965628905348653228L),
new System.Numerics.BigInteger(5837014550032684371L),
},
},
            new BigIntegernumericArray1M
{
    Id = 7,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7279605012502904823L),
new System.Numerics.BigInteger(3865144043826493900L),
new System.Numerics.BigInteger(7264455405287267700L),
new System.Numerics.BigInteger(2892742350600298171L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9221284859285553570L),
new System.Numerics.BigInteger(3811400961564492123L),
new System.Numerics.BigInteger(8816690819399105187L),
new System.Numerics.BigInteger(7244736440446128430L),
},
},
            new BigIntegernumericArray1M
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2344047896928843502L),
new System.Numerics.BigInteger(3387228640171709552L),
new System.Numerics.BigInteger(1240019332121853104L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 10,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1348065782335745243L),
new System.Numerics.BigInteger(607598795549401418L),
new System.Numerics.BigInteger(9214074786929032938L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2054623288141599471L),
new System.Numerics.BigInteger(7446764410976681657L),
new System.Numerics.BigInteger(3309468286608195247L),
},
},
            new BigIntegernumericArray1M
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6342693973524050036L),
new System.Numerics.BigInteger(98501235515094377L),
new System.Numerics.BigInteger(8338620423183837592L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8069055232845799128L),
new System.Numerics.BigInteger(4717881194377633929L),
new System.Numerics.BigInteger(4473794665756336737L),
new System.Numerics.BigInteger(7528145600400822070L),
},
},
            new BigIntegernumericArray1M
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8435346806965423190L),
new System.Numerics.BigInteger(729583760540710322L),
new System.Numerics.BigInteger(6909638681841737286L),
new System.Numerics.BigInteger(2458664100502722523L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1028343627771096270L),
new System.Numerics.BigInteger(3032735235675768391L),
new System.Numerics.BigInteger(8036388739525731377L),
new System.Numerics.BigInteger(3627545521459574705L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3015732863248218533L),
new System.Numerics.BigInteger(6993685222091862996L),
new System.Numerics.BigInteger(1005140904439880059L),
new System.Numerics.BigInteger(6199385113973737730L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4675197375320058239L),
new System.Numerics.BigInteger(6427091754438038349L),
new System.Numerics.BigInteger(3226517024721790838L),
new System.Numerics.BigInteger(4670699716626810523L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4850591510574192144L),
new System.Numerics.BigInteger(2375956601111953411L),
new System.Numerics.BigInteger(992405440554552736L),
new System.Numerics.BigInteger(5192406301085141623L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6687168573323213815L),
new System.Numerics.BigInteger(5579256055275833987L),
new System.Numerics.BigInteger(7293032891715827838L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6860486859014848338L),
new System.Numerics.BigInteger(7773433447604442307L),
new System.Numerics.BigInteger(3272169700500550870L),
new System.Numerics.BigInteger(7830036516851763571L),
},
},
            new BigIntegernumericArray1M
{
    Id = 51,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8427841641804912801L),
new System.Numerics.BigInteger(3426384213091215026L),
new System.Numerics.BigInteger(8397359458611250128L),
new System.Numerics.BigInteger(5613487188821868649L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3933943429815015667L),
new System.Numerics.BigInteger(686740221900694426L),
new System.Numerics.BigInteger(5053726993903114466L),
new System.Numerics.BigInteger(4410927711680650281L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 33,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1498102486889428489L),
new System.Numerics.BigInteger(7285028153404077152L),
new System.Numerics.BigInteger(886811577687551493L),
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
new System.Numerics.BigInteger(7292762422966567431L),
new System.Numerics.BigInteger(1659519636728821156L),
new System.Numerics.BigInteger(6000523628499697119L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3082631040221214349L),
new System.Numerics.BigInteger(5663322317284991371L),
new System.Numerics.BigInteger(9113124455111808605L),
},
},
            new BigIntegernumericArray1M
{
    Id = 63,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7819678029895161037L),
new System.Numerics.BigInteger(4138854208677063466L),
new System.Numerics.BigInteger(6287692231957751754L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(158447492575956472L),
new System.Numerics.BigInteger(1353826361039284075L),
new System.Numerics.BigInteger(796370579450297839L),
new System.Numerics.BigInteger(1029780816717133672L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4767488343142328944L),
new System.Numerics.BigInteger(3788207008990548518L),
new System.Numerics.BigInteger(9059166421452903913L),
new System.Numerics.BigInteger(8680132970007681590L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(90647740937131373L),
new System.Numerics.BigInteger(3162835324503550678L),
new System.Numerics.BigInteger(7168772733364765271L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8596865735486534697L),
new System.Numerics.BigInteger(5430167424739034131L),
new System.Numerics.BigInteger(1932282979828350991L),
},
},
            new BigIntegernumericArray1M
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3567558678787854730L),
new System.Numerics.BigInteger(1960243856796100837L),
new System.Numerics.BigInteger(3338549394533056254L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4865599649864117502L),
new System.Numerics.BigInteger(646194419364917938L),
new System.Numerics.BigInteger(2197076842174123406L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6272640297688802047L),
new System.Numerics.BigInteger(5744277266836549776L),
new System.Numerics.BigInteger(7073896543203551447L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2058432808523503232L),
new System.Numerics.BigInteger(8626385235359602177L),
new System.Numerics.BigInteger(7517181032258427468L),
},
},
            new BigIntegernumericArray1M
{
    Id = 79,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5719589098898443678L),
new System.Numerics.BigInteger(1523676558667128308L),
new System.Numerics.BigInteger(6002301496932428629L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8711555497953417603L),
new System.Numerics.BigInteger(2976721680724104720L),
new System.Numerics.BigInteger(8442176906070283245L),
new System.Numerics.BigInteger(9019459894228612902L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6495963696070420406L),
new System.Numerics.BigInteger(2252095835640043335L),
new System.Numerics.BigInteger(8953245206379424927L),
new System.Numerics.BigInteger(4815569181622454289L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1273513069804897805L),
new System.Numerics.BigInteger(2477402639620153995L),
new System.Numerics.BigInteger(1958794429532970015L),
new System.Numerics.BigInteger(7567925925325234758L),
},
},
            new BigIntegernumericArray1M
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5106694631350594134L),
new System.Numerics.BigInteger(5981154827428898375L),
new System.Numerics.BigInteger(6763256337686599516L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 96,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4016274224024745064L),
new System.Numerics.BigInteger(1304579674674794787L),
new System.Numerics.BigInteger(1211329640079235309L),
new System.Numerics.BigInteger(3373702929679508220L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(303869812327074802L),
new System.Numerics.BigInteger(4863650535052239614L),
new System.Numerics.BigInteger(7612681264468153985L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3847471247470631635L),
new System.Numerics.BigInteger(5838406288846376875L),
new System.Numerics.BigInteger(2575066801645827919L),
},
},
            new BigIntegernumericArray1M
{
    Id = 100,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5018200566056118807L),
new System.Numerics.BigInteger(8746253391791436811L),
new System.Numerics.BigInteger(8586891880519560878L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(755284700374419077L),
new System.Numerics.BigInteger(5453971170243498728L),
new System.Numerics.BigInteger(9158011168476089788L),
new System.Numerics.BigInteger(4680268536518723175L),
},
},
            new BigIntegernumericArray1M
{
    Id = 106,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6700681883083119784L),
new System.Numerics.BigInteger(4935149985141351572L),
new System.Numerics.BigInteger(1017713839984994748L),
new System.Numerics.BigInteger(7219162953552236980L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5087400089887090986L),
new System.Numerics.BigInteger(4953464596799342887L),
new System.Numerics.BigInteger(5725414966358223087L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 110,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4105441782605778365L),
new System.Numerics.BigInteger(8164814135900323938L),
new System.Numerics.BigInteger(8083170656161931484L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2972654382634220942L),
new System.Numerics.BigInteger(1458399355580660372L),
new System.Numerics.BigInteger(2765132513834415248L),
},
},
            new BigIntegernumericArray1M
{
    Id = 116,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2578211775201842265L),
new System.Numerics.BigInteger(2789395479512528708L),
new System.Numerics.BigInteger(7702360498727718119L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5259561209052940075L),
new System.Numerics.BigInteger(8357252508074035628L),
new System.Numerics.BigInteger(2295966428923281669L),
new System.Numerics.BigInteger(3186689754010426651L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2718217807055718899L),
new System.Numerics.BigInteger(4513923925451636685L),
new System.Numerics.BigInteger(5007014145501269749L),
},
},
            new BigIntegernumericArray1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(652085782909171266L),
new System.Numerics.BigInteger(2749082889693891154L),
new System.Numerics.BigInteger(3790835812538019941L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5817393541035530507L),
new System.Numerics.BigInteger(6046427593964254529L),
new System.Numerics.BigInteger(2440031130158168914L),
},
},
            new BigIntegernumericArray1M
{
    Id = 126,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3482589091756982573L),
new System.Numerics.BigInteger(7923325642215404900L),
new System.Numerics.BigInteger(29370549286211977L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 69,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1066613079664457377L),
new System.Numerics.BigInteger(8259222101055852695L),
new System.Numerics.BigInteger(3772138057405662481L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 134,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(744535335564484005L),
new System.Numerics.BigInteger(6794194742883212273L),
new System.Numerics.BigInteger(24075196155054513L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7879429054108524867L),
new System.Numerics.BigInteger(1443850355301674923L),
new System.Numerics.BigInteger(2968961042459822154L),
new System.Numerics.BigInteger(560658473596476066L),
},
},
            new BigIntegernumericArray1M
{
    Id = 141,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2232554647403418010L),
new System.Numerics.BigInteger(3806635282606244930L),
new System.Numerics.BigInteger(6003842892496835697L),
new System.Numerics.BigInteger(3910563373749862041L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8132902583536490242L),
new System.Numerics.BigInteger(9192649624687486155L),
new System.Numerics.BigInteger(7859812496120918377L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7083524459485085423L),
new System.Numerics.BigInteger(3873627005188647066L),
new System.Numerics.BigInteger(7741310523026069804L),
},
},
            new BigIntegernumericArray1M
{
    Id = 148,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6560568877704686906L),
new System.Numerics.BigInteger(9217547318441694494L),
new System.Numerics.BigInteger(1586076249817163579L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 151,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6438325658410764009L),
new System.Numerics.BigInteger(5643011946610526557L),
new System.Numerics.BigInteger(5501046775763242254L),
new System.Numerics.BigInteger(6245995976837266719L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3043930322179858645L),
new System.Numerics.BigInteger(5854687545715062054L),
new System.Numerics.BigInteger(1928258786735678099L),
new System.Numerics.BigInteger(7261398257885313331L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 159,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6347668487959680350L),
new System.Numerics.BigInteger(4547809423404122919L),
new System.Numerics.BigInteger(6527999556951551519L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4998063637194119707L),
new System.Numerics.BigInteger(4254053710073799182L),
new System.Numerics.BigInteger(4200623796336706789L),
},
},
            new BigIntegernumericArray1M
{
    Id = 164,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5573850338712737731L),
new System.Numerics.BigInteger(3541131920921754439L),
new System.Numerics.BigInteger(4537205929143350577L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 88,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5633179336639038482L),
new System.Numerics.BigInteger(8213831901820799868L),
new System.Numerics.BigInteger(3017879315717639244L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(350953142853819751L),
new System.Numerics.BigInteger(8410607690903041988L),
new System.Numerics.BigInteger(8155895968476336019L),
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
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
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
BigIntegernumericArray1M.AssertModel(models[0],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
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
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
BigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 79, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 2, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[1], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[2], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[3], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[4], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[5], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[6], false);FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[7], false);FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[8], false);FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[9], false);FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[10], false);FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[11], false);FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[12], false);FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[13], false);FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[14], false);FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[15], false);FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[16], false);FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[17], false);FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[18], false);FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[19], false);FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[20], false);FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[21], false);FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[22], false);FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[23], false);FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[24], false);FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[25], false);FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[26], false);FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[27], false);FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[28], false);FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[29], false);
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatchAsync(connection, 151, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
BigIntegernumericArray1M.AssertModel(models[0],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[29], false);
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
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatch(connection, 47, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
BigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
BigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
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
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
BigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
BigIntegernumericArray1M.AssertModel(models[0],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[29], false);
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

