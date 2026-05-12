

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
    internal partial interface IBigIntegerMArraynumericMMArrayD1
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD1 : IBigIntegerMArraynumericMMArrayD1
    {


#region TestData

        private readonly BigIntegernumericMMArrayD1E1M[] _testData = new BigIntegernumericMMArrayD1E1M[]
        {
            new BigIntegernumericMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2454527206456399959L),
new System.Numerics.BigInteger(8065362239261178719L),
new System.Numerics.BigInteger(7951574622063150595L),
new System.Numerics.BigInteger(5127579061289685909L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7979352539217339294L),
new System.Numerics.BigInteger(1951446811483256003L),
new System.Numerics.BigInteger(8748049627573037389L),
new System.Numerics.BigInteger(1018835595142053106L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4983505068604181254L),
new System.Numerics.BigInteger(1674248039756120892L),
new System.Numerics.BigInteger(4413791280238687096L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4563245947328132956L),
new System.Numerics.BigInteger(4766429944463103363L),
new System.Numerics.BigInteger(2516500467271215730L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(830244644677928627L),
new System.Numerics.BigInteger(6229859525428847920L),
new System.Numerics.BigInteger(7662389577411107821L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3874834825208890946L),
new System.Numerics.BigInteger(776884324191055213L),
new System.Numerics.BigInteger(5250880828706133926L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1914332261842861424L),
new System.Numerics.BigInteger(1642881860183929737L),
new System.Numerics.BigInteger(1351205332354250483L),
new System.Numerics.BigInteger(6291947845098031812L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4660772297138067508L),
new System.Numerics.BigInteger(9040221744940123474L),
new System.Numerics.BigInteger(2196897000686842565L),
new System.Numerics.BigInteger(197171219937500458L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7571175537353736575L),
new System.Numerics.BigInteger(5064974593874259766L),
new System.Numerics.BigInteger(7163316749872553917L),
new System.Numerics.BigInteger(8258737398299525877L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3246378634192121788L),
new System.Numerics.BigInteger(5735589979457445161L),
new System.Numerics.BigInteger(1375447002722139950L),
new System.Numerics.BigInteger(2351340781996586281L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7054566298289722413L),
new System.Numerics.BigInteger(3846088735811688757L),
new System.Numerics.BigInteger(5135621019811856681L),
new System.Numerics.BigInteger(7717749757154743890L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3840416786452966093L),
new System.Numerics.BigInteger(8877079758617391938L),
new System.Numerics.BigInteger(6772988617797849821L),
new System.Numerics.BigInteger(6508076848716469994L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8606184072491915695L),
new System.Numerics.BigInteger(1310040867941252089L),
new System.Numerics.BigInteger(7528958095937044971L),
new System.Numerics.BigInteger(4706791162462341058L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4957423181622826169L),
new System.Numerics.BigInteger(3342904378234918308L),
new System.Numerics.BigInteger(3105729833208826980L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8638433963102178545L),
new System.Numerics.BigInteger(6117793615855640504L),
new System.Numerics.BigInteger(1859380008629314913L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3257190922581074303L),
new System.Numerics.BigInteger(4223605047426174012L),
new System.Numerics.BigInteger(683601024794131696L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2390931755746612566L),
new System.Numerics.BigInteger(960040600556421895L),
new System.Numerics.BigInteger(3112275316777623440L),
new System.Numerics.BigInteger(6100008832574827392L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7144815123676950220L),
new System.Numerics.BigInteger(6677259195019303801L),
new System.Numerics.BigInteger(4416402336791799607L),
new System.Numerics.BigInteger(970990546775367500L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1326543138035549604L),
new System.Numerics.BigInteger(1693978619215028723L),
new System.Numerics.BigInteger(4107492347773074078L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3071895824607174294L),
new System.Numerics.BigInteger(6881643877199360881L),
new System.Numerics.BigInteger(1092664177842769796L),
new System.Numerics.BigInteger(5989354524830633385L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(260215601985401461L),
new System.Numerics.BigInteger(265966579994065472L),
new System.Numerics.BigInteger(3082708071071244844L),
new System.Numerics.BigInteger(5622172085894008861L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2757611522216654963L),
new System.Numerics.BigInteger(3254001105544522083L),
new System.Numerics.BigInteger(5785452542095762055L),
new System.Numerics.BigInteger(5950993836598039950L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(658977911547416114L),
new System.Numerics.BigInteger(1658611369405604405L),
new System.Numerics.BigInteger(1233761626476102292L),
new System.Numerics.BigInteger(2570727965980111925L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2168707458943250444L),
new System.Numerics.BigInteger(3173143527069073178L),
new System.Numerics.BigInteger(1273255395979054081L),
new System.Numerics.BigInteger(2614601109915370346L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4101206045084400031L),
new System.Numerics.BigInteger(5668327612832195457L),
new System.Numerics.BigInteger(3157875545677410244L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1509126172943903278L),
new System.Numerics.BigInteger(1241604696079566460L),
new System.Numerics.BigInteger(3500238956055333335L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2161598729227268707L),
new System.Numerics.BigInteger(6384752076798606622L),
new System.Numerics.BigInteger(455758623734574156L),
new System.Numerics.BigInteger(5303168698083330453L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1660862370327180580L),
new System.Numerics.BigInteger(7575341098846166707L),
new System.Numerics.BigInteger(2403745270187845136L),
new System.Numerics.BigInteger(6921034072588867130L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1341124243118149540L),
new System.Numerics.BigInteger(1178096864436957986L),
new System.Numerics.BigInteger(2282062999197135269L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7181292362671083216L),
new System.Numerics.BigInteger(3832060656140745089L),
new System.Numerics.BigInteger(6971417823325652005L),
new System.Numerics.BigInteger(5353814309090364338L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2286314297376861760L),
new System.Numerics.BigInteger(3934901614870519538L),
new System.Numerics.BigInteger(4981627670273871197L),
new System.Numerics.BigInteger(3177686126742066051L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2169427495229629225L),
new System.Numerics.BigInteger(7740594609561810106L),
new System.Numerics.BigInteger(3429285655363774859L),
new System.Numerics.BigInteger(5443877931775071804L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8283451362535958397L),
new System.Numerics.BigInteger(7081168094154588104L),
new System.Numerics.BigInteger(6224407222070493904L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5377445254951994058L),
new System.Numerics.BigInteger(4028688585172268025L),
new System.Numerics.BigInteger(3501208807965884794L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7631265115970011374L),
new System.Numerics.BigInteger(4703143310047415504L),
new System.Numerics.BigInteger(2478943581152188086L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3544820444418348221L),
new System.Numerics.BigInteger(514440431928289060L),
new System.Numerics.BigInteger(6281465060150620899L),
new System.Numerics.BigInteger(6831122357349639907L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9132066462761268329L),
new System.Numerics.BigInteger(5994646708282433892L),
new System.Numerics.BigInteger(289998574767406052L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4827555217298605379L),
new System.Numerics.BigInteger(5779396564881843060L),
new System.Numerics.BigInteger(3187371495675941221L),
new System.Numerics.BigInteger(4280156314727988851L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9078953169438743631L),
new System.Numerics.BigInteger(1064366809426578299L),
new System.Numerics.BigInteger(4641301012280953124L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6292767835962591085L),
new System.Numerics.BigInteger(7758168559174929176L),
new System.Numerics.BigInteger(1291707899707007463L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1138855399693496657L),
new System.Numerics.BigInteger(1906168390194205524L),
new System.Numerics.BigInteger(7431447151773946287L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4208998764155380539L),
new System.Numerics.BigInteger(6969561574275447230L),
new System.Numerics.BigInteger(3047515026489561473L),
new System.Numerics.BigInteger(7711315415169287287L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8196225961596698258L),
new System.Numerics.BigInteger(3891073074196900744L),
new System.Numerics.BigInteger(507144697753490294L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1040598646904058901L),
new System.Numerics.BigInteger(2387447848489885953L),
new System.Numerics.BigInteger(3972589261374292538L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2881964994107105747L),
new System.Numerics.BigInteger(6601766484352436972L),
new System.Numerics.BigInteger(1130284371703971642L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7041802330275673783L),
new System.Numerics.BigInteger(2842591300066006580L),
new System.Numerics.BigInteger(467601946434412162L),
new System.Numerics.BigInteger(663342995844157142L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7246744202342140428L),
new System.Numerics.BigInteger(8414287789015160217L),
new System.Numerics.BigInteger(7050411327477962099L),
new System.Numerics.BigInteger(151577419438182133L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1156040445675634420L),
new System.Numerics.BigInteger(2841894876070694717L),
new System.Numerics.BigInteger(6058806256193959804L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8907659878614310126L),
new System.Numerics.BigInteger(3730832428998205326L),
new System.Numerics.BigInteger(1010508686838604849L),
new System.Numerics.BigInteger(1104223483155474728L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2243804441614430625L),
new System.Numerics.BigInteger(7638190551065910104L),
new System.Numerics.BigInteger(312314821609510648L),
new System.Numerics.BigInteger(6761871916092303655L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6594383154295405188L),
new System.Numerics.BigInteger(222586658769991635L),
new System.Numerics.BigInteger(2047450629026791120L),
new System.Numerics.BigInteger(4411335903776235680L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7504310550733890939L),
new System.Numerics.BigInteger(1579677323444575266L),
new System.Numerics.BigInteger(7016781842189858964L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1091328939571281615L),
new System.Numerics.BigInteger(6474761432340293929L),
new System.Numerics.BigInteger(4716045723832323909L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4034791184890748790L),
new System.Numerics.BigInteger(278375490181708768L),
new System.Numerics.BigInteger(67016981957817123L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8681076005267857142L),
new System.Numerics.BigInteger(10638081506633769L),
new System.Numerics.BigInteger(5059131742431891765L),
new System.Numerics.BigInteger(6260006424243362989L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6088189540454622218L),
new System.Numerics.BigInteger(6947556568406161192L),
new System.Numerics.BigInteger(2845860756596541346L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1041102327524242038L),
new System.Numerics.BigInteger(1269430063061024713L),
new System.Numerics.BigInteger(4323317886021333808L),
new System.Numerics.BigInteger(989364785287653584L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3461751067245437591L),
new System.Numerics.BigInteger(4698791170576710115L),
new System.Numerics.BigInteger(1397553973433531893L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8117062322997671611L),
new System.Numerics.BigInteger(8008478741206804802L),
new System.Numerics.BigInteger(4069862718014008317L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 142,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(427194825047387107L),
new System.Numerics.BigInteger(4108373863565592026L),
new System.Numerics.BigInteger(912773719034500943L),
new System.Numerics.BigInteger(7036568585534654810L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2226057384036020172L),
new System.Numerics.BigInteger(2272827860814409105L),
new System.Numerics.BigInteger(7065064580689677098L),
new System.Numerics.BigInteger(4305644702339298055L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4702447931391247451L),
new System.Numerics.BigInteger(568934783642604522L),
new System.Numerics.BigInteger(3081068644676459855L),
new System.Numerics.BigInteger(1854333539256129838L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5089768464496861523L),
new System.Numerics.BigInteger(2546946293807816445L),
new System.Numerics.BigInteger(5768823688952240526L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3529780573178260706L),
new System.Numerics.BigInteger(6989969012629464651L),
new System.Numerics.BigInteger(3201611147432131264L),
new System.Numerics.BigInteger(1400515202902678908L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5886307935925136865L),
new System.Numerics.BigInteger(4187868187714176085L),
new System.Numerics.BigInteger(7993221669653920933L),
new System.Numerics.BigInteger(5020600244242066503L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2026954067861265575L),
new System.Numerics.BigInteger(6176854388605566173L),
new System.Numerics.BigInteger(4435669215332139644L),
new System.Numerics.BigInteger(8238687696956123155L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5305494987442133034L),
new System.Numerics.BigInteger(543289425209113104L),
new System.Numerics.BigInteger(4254581167506807231L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1334871305623220890L),
new System.Numerics.BigInteger(8194334483831266488L),
new System.Numerics.BigInteger(55974314470221173L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(289181663511153947L),
new System.Numerics.BigInteger(6852446848404692225L),
new System.Numerics.BigInteger(4615824465771464876L),
new System.Numerics.BigInteger(2684709969597180607L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 174,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(192589093534333531L),
new System.Numerics.BigInteger(7561596416869273715L),
new System.Numerics.BigInteger(357664676971901593L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2883216699573980511L),
new System.Numerics.BigInteger(5449131555710354176L),
new System.Numerics.BigInteger(7292683220781268644L),
new System.Numerics.BigInteger(135906544643602998L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5251229357686772095L),
new System.Numerics.BigInteger(7873950101238171048L),
new System.Numerics.BigInteger(1450170498067184490L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 182,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7002837767819396733L),
new System.Numerics.BigInteger(3431065903742679215L),
new System.Numerics.BigInteger(7800280802825733493L),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
INSERT INTO public.bigintegernumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)), 
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
                methodParametrName: "bigintegernumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                methodParametrName: "bigintegernumericmmarrayd1e1mi_id", 
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
                List<BigIntegernumericMMArrayD1E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD1E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 112;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 55, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 87, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 96, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 96, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 163, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 163, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 31, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MI),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1M),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
FROM public.binary_bigintegernumericmmarrayd1e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI), typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MI>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

