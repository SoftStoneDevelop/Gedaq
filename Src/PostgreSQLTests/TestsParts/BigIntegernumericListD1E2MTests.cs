

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
    internal partial interface IBigIntegerListnumericListD1
    {
    }
    
    internal partial class BigIntegerListnumericListD1 : IBigIntegerListnumericListD1
    {


#region TestData

        private readonly BigIntegernumericListD1E2M[] _testData = new BigIntegernumericListD1E2M[]
        {
            new BigIntegernumericListD1E2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6806355980412539229L),

new System.Numerics.BigInteger(1186349986713237814L),

new System.Numerics.BigInteger(5662589736881841026L),

new System.Numerics.BigInteger(8662164280889608243L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5020347554024760848L),

new System.Numerics.BigInteger(5314311476377327475L),

new System.Numerics.BigInteger(8127206802914361165L),

new System.Numerics.BigInteger(4401542167702092759L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3888847978904792079L),

new System.Numerics.BigInteger(4359768607127877479L),

new System.Numerics.BigInteger(1425275267326559986L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1039388249593119373L),

new System.Numerics.BigInteger(2342129328461455688L),

new System.Numerics.BigInteger(8817562021245657455L),

new System.Numerics.BigInteger(1140772673829731888L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8267901733781789545L),

new System.Numerics.BigInteger(1810735876814560428L),

new System.Numerics.BigInteger(4944320065018336377L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(150081710668649206L),

new System.Numerics.BigInteger(8542763224363782744L),

new System.Numerics.BigInteger(571690225555075179L),

new System.Numerics.BigInteger(6322239954117313898L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2778487648318387970L),

new System.Numerics.BigInteger(8911016768266186835L),

new System.Numerics.BigInteger(2906744482701583174L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6801018960409571810L),

new System.Numerics.BigInteger(4572539221389845794L),

new System.Numerics.BigInteger(3232786292482188389L),

new System.Numerics.BigInteger(6159379685182585233L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(477055042958493338L),

new System.Numerics.BigInteger(2543755910228656358L),

new System.Numerics.BigInteger(3970442331404570993L),

new System.Numerics.BigInteger(2199482283846087399L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8237370293970380935L),

new System.Numerics.BigInteger(8868073374291070055L),

new System.Numerics.BigInteger(1455669020472833508L),

new System.Numerics.BigInteger(5932062516905013170L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3120762561830350366L),

new System.Numerics.BigInteger(9071133307188356665L),

new System.Numerics.BigInteger(6922111203919878340L),

new System.Numerics.BigInteger(7834520974407992759L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6395738625958409394L),

new System.Numerics.BigInteger(7580311071297841945L),

new System.Numerics.BigInteger(1439585161061799076L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1965595628338891425L),

new System.Numerics.BigInteger(2564246666477508227L),

new System.Numerics.BigInteger(9130750617545030350L),

new System.Numerics.BigInteger(6658409154210429036L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7838291060375371450L),

new System.Numerics.BigInteger(8557765580492580498L),

new System.Numerics.BigInteger(3010809405868215931L),

new System.Numerics.BigInteger(3037937217098122807L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4865131246689287314L),

new System.Numerics.BigInteger(7375449718070390424L),

new System.Numerics.BigInteger(1883611309235926625L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8611679356899807628L),

new System.Numerics.BigInteger(4840868145987379468L),

new System.Numerics.BigInteger(683656866102869097L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8947185065077941575L),

new System.Numerics.BigInteger(7920436667345467810L),

new System.Numerics.BigInteger(2291602702013608376L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8602466198152528120L),

new System.Numerics.BigInteger(7007935168397894037L),

new System.Numerics.BigInteger(6666980561465421904L),

new System.Numerics.BigInteger(4866459520962645909L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9080660199606952055L),

new System.Numerics.BigInteger(4848368932605750958L),

new System.Numerics.BigInteger(2793561514317790600L),

new System.Numerics.BigInteger(2678882442382203653L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(516580311362035859L),

new System.Numerics.BigInteger(4871228210749045559L),

new System.Numerics.BigInteger(44657417517115986L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6143556809955403075L),

new System.Numerics.BigInteger(4196633981445090595L),

new System.Numerics.BigInteger(6855127116447024776L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5156696333023666094L),

new System.Numerics.BigInteger(164293167708878688L),

new System.Numerics.BigInteger(721235921747905925L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8664191401811654455L),

new System.Numerics.BigInteger(9147815334920642310L),

new System.Numerics.BigInteger(1156712223980764352L),

new System.Numerics.BigInteger(3666688425882219740L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6579547968271515237L),

new System.Numerics.BigInteger(3519093510959422899L),

new System.Numerics.BigInteger(2597194739645367885L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2567955581622354855L),

new System.Numerics.BigInteger(195900413230043621L),

new System.Numerics.BigInteger(2785270457913098238L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(218403101087984957L),

new System.Numerics.BigInteger(27046827507435292L),

new System.Numerics.BigInteger(1127511284921391440L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8949430082189317324L),

new System.Numerics.BigInteger(6390407292263590896L),

new System.Numerics.BigInteger(3515164738660090034L),

new System.Numerics.BigInteger(7197780120682646092L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1763658113234174710L),

new System.Numerics.BigInteger(931247459761058488L),

new System.Numerics.BigInteger(1283984124612549736L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7416525450714600923L),

new System.Numerics.BigInteger(2719076377564961530L),

new System.Numerics.BigInteger(7292509372867255890L),

new System.Numerics.BigInteger(8438174534018839480L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2939197223985758896L),

new System.Numerics.BigInteger(7324152191027449545L),

new System.Numerics.BigInteger(2488670670479280309L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4777857997768670642L),

new System.Numerics.BigInteger(5115298065825928303L),

new System.Numerics.BigInteger(3199091381406842780L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5091906370597368670L),

new System.Numerics.BigInteger(1021652081150691979L),

new System.Numerics.BigInteger(185393775159467491L),

new System.Numerics.BigInteger(1803675277045862895L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3842875854379970439L),

new System.Numerics.BigInteger(2831062203233182969L),

new System.Numerics.BigInteger(6117338610896157568L),

new System.Numerics.BigInteger(4386833419465901602L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5214272574050843204L),

new System.Numerics.BigInteger(8474105555747699779L),

new System.Numerics.BigInteger(461941527380910816L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9049133669254333079L),

new System.Numerics.BigInteger(7666554912754339655L),

new System.Numerics.BigInteger(32048960244136180L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2424998519777820237L),

new System.Numerics.BigInteger(715961622141581393L),

new System.Numerics.BigInteger(7185207205184648622L),

new System.Numerics.BigInteger(8969403022729501418L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(158151221467539700L),

new System.Numerics.BigInteger(8421662297524268224L),

new System.Numerics.BigInteger(8813141930439562598L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9053437258467386555L),

new System.Numerics.BigInteger(7519727172852742273L),

new System.Numerics.BigInteger(1834862602051072905L),

new System.Numerics.BigInteger(5687914053062793738L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8389018798714251323L),

new System.Numerics.BigInteger(6884868285272903083L),

new System.Numerics.BigInteger(3138858760354431904L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6668735835762229695L),

new System.Numerics.BigInteger(3347121648003170629L),

new System.Numerics.BigInteger(2986039777857832976L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5454911238433385247L),

new System.Numerics.BigInteger(5902085507688268668L),

new System.Numerics.BigInteger(1771646917972438697L),

new System.Numerics.BigInteger(2853073354555801430L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(855970939975422974L),

new System.Numerics.BigInteger(474276924021479175L),

new System.Numerics.BigInteger(8021194728564999595L),

new System.Numerics.BigInteger(7191267797374277019L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4868694340818779975L),

new System.Numerics.BigInteger(858060224470005684L),

new System.Numerics.BigInteger(535730135221136149L),

new System.Numerics.BigInteger(5542571789135632162L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6693143084778723254L),

new System.Numerics.BigInteger(2336153528710613916L),

new System.Numerics.BigInteger(1495316765013151152L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3376970209220328741L),

new System.Numerics.BigInteger(2516819458134392780L),

new System.Numerics.BigInteger(7785726442771531752L),

new System.Numerics.BigInteger(4010835859390500052L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2857762759965524252L),

new System.Numerics.BigInteger(6909571625202027779L),

new System.Numerics.BigInteger(1152545545148988211L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2659885304586098340L),

new System.Numerics.BigInteger(5371361742485823478L),

new System.Numerics.BigInteger(9037344069763769895L),

new System.Numerics.BigInteger(7970519486974521762L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3184432152997984831L),

new System.Numerics.BigInteger(7769495533255419350L),

new System.Numerics.BigInteger(2357797575450547142L),

new System.Numerics.BigInteger(349713287371177471L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8960201587918114883L),

new System.Numerics.BigInteger(4183445854361035560L),

new System.Numerics.BigInteger(8857007781432425338L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1694727342683575825L),

new System.Numerics.BigInteger(258824614595924816L),

new System.Numerics.BigInteger(6134889735630504713L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8499477917276245477L),

new System.Numerics.BigInteger(3949909434771557035L),

new System.Numerics.BigInteger(8569577732356257611L),

new System.Numerics.BigInteger(6014198934946203825L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2874413358142670438L),

new System.Numerics.BigInteger(6899591871987456732L),

new System.Numerics.BigInteger(7651799264918879938L),

new System.Numerics.BigInteger(6324574648789224395L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1849559141039497090L),

new System.Numerics.BigInteger(5096358053865576051L),

new System.Numerics.BigInteger(2185890799285562555L),

new System.Numerics.BigInteger(4619993400017988324L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2756427697004636229L),

new System.Numerics.BigInteger(3903111777272096799L),

new System.Numerics.BigInteger(4038538732028839618L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8955326865410073616L),

new System.Numerics.BigInteger(3942465052684782092L),

new System.Numerics.BigInteger(881630953971596983L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6912081703282705118L),

new System.Numerics.BigInteger(617300668239336849L),

new System.Numerics.BigInteger(3995538796177383074L),

new System.Numerics.BigInteger(6174416415391022035L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2937382758228789249L),

new System.Numerics.BigInteger(5625350964182151553L),

new System.Numerics.BigInteger(7005169794086575112L),

new System.Numerics.BigInteger(723758416952995814L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3602788339676504626L),

new System.Numerics.BigInteger(1306639125047817641L),

new System.Numerics.BigInteger(3209617320135181422L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2161603202395784664L),

new System.Numerics.BigInteger(6754462176230511676L),

new System.Numerics.BigInteger(920081926289763174L),

new System.Numerics.BigInteger(1859197079486648039L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5444507339263262573L),

new System.Numerics.BigInteger(570216592441726762L),

new System.Numerics.BigInteger(2453111602397249090L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7944753919542549563L),

new System.Numerics.BigInteger(67716250196593052L),

new System.Numerics.BigInteger(8531709746809493474L),

new System.Numerics.BigInteger(8830289745887326470L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8629850021038538239L),

new System.Numerics.BigInteger(6351700927187349467L),

new System.Numerics.BigInteger(7248703789649973079L),

new System.Numerics.BigInteger(4212525213254607190L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2591226487037424866L),

new System.Numerics.BigInteger(1555714926947187236L),

new System.Numerics.BigInteger(268918962985072743L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2770994065510752537L),

new System.Numerics.BigInteger(3065869521438439748L),

new System.Numerics.BigInteger(1586112254022493677L),

new System.Numerics.BigInteger(5152545738885837468L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6322069603988274968L),

new System.Numerics.BigInteger(2663075819723074725L),

new System.Numerics.BigInteger(205413390842606616L),

new System.Numerics.BigInteger(1749022096295127669L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7823849192484701037L),

new System.Numerics.BigInteger(8911699947875335959L),

new System.Numerics.BigInteger(6161162848019453740L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(301443388296752970L),

new System.Numerics.BigInteger(3740152320849489383L),

new System.Numerics.BigInteger(7134035981140613010L),

new System.Numerics.BigInteger(5072542375374412623L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6793793118215857377L),

new System.Numerics.BigInteger(8872081566270545062L),

new System.Numerics.BigInteger(924205888899321673L),

new System.Numerics.BigInteger(2548800563737637456L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2438956119221253203L),

new System.Numerics.BigInteger(4461256298361076823L),

new System.Numerics.BigInteger(2911245172326816241L),

new System.Numerics.BigInteger(8406237447452285283L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8493866557124137615L),

new System.Numerics.BigInteger(5773756607180194462L),

new System.Numerics.BigInteger(4260119351793206341L),

new System.Numerics.BigInteger(7756231257210010063L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1972086830793633742L),

new System.Numerics.BigInteger(9065929919713894179L),

new System.Numerics.BigInteger(844756808543769159L),

new System.Numerics.BigInteger(1602649204305634725L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5941153568748426664L),

new System.Numerics.BigInteger(7071754734859899999L),

new System.Numerics.BigInteger(4694762278428988785L),

new System.Numerics.BigInteger(2372098412607205879L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1121708789853494842L),

new System.Numerics.BigInteger(7272670944801725451L),

new System.Numerics.BigInteger(6915077673227286210L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5362729937611040227L),

new System.Numerics.BigInteger(166720556787710534L),

new System.Numerics.BigInteger(7609131971969226457L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7608390411273752702L),

new System.Numerics.BigInteger(6269514133175617567L),

new System.Numerics.BigInteger(3801728421181455560L),

new System.Numerics.BigInteger(1704282939332629787L),

},
    ModelInner = new BigIntegernumericListD12MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(267962877766349626L),

new System.Numerics.BigInteger(1893250940575734911L),

new System.Numerics.BigInteger(2457332807817178594L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2287900024350204202L),

new System.Numerics.BigInteger(7687885029564505772L),

new System.Numerics.BigInteger(5241330744183762653L),

new System.Numerics.BigInteger(178806350102215742L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(393928293389419872L),

new System.Numerics.BigInteger(3583348452537133252L),

new System.Numerics.BigInteger(8009450799919798931L),

new System.Numerics.BigInteger(6168282826644101993L),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd12mi(
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd12mi(
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
            queryMapTypes: [typeof(BigIntegernumericListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
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

                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd12mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericlistd12mi_id", 
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
                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd12mi_id
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
    bigintegernumericlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd12mi_id
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
    bigintegernumericlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericlistd12mi_id", 
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
                List<BigIntegernumericListD1E2M> models = null;

                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericListD1E2M> models = null;

                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd12mi mi ON mi.id = m.bigintegernumericlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd12mi mi ON mi.id = m.bigintegernumericlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 127;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd12mi mi ON mi.id = m.bigintegernumericlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 2, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 93, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 112, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 85, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 76, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd12mi mi ON mi.id = m.bigintegernumericlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 41, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 8, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[16], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[17], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[18], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[19], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[20], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[21], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[13],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[14],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[15],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[16],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[17],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models =  ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[13], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[14], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[15], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[16], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[17], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[18], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[19], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[20], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[21], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[13],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[14],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[15],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[16],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[17],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[18],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[19],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[20],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_bigintegernumericlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD12MIWA),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD12MI),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericlistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericListD1E2M),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
FROM public.binary_bigintegernumericlistd1e2m m
LEFT JOIN public.binary_bigintegernumericlistd12mi mi ON mi.id = m.bigintegernumericlistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericListD1)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericlistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models =  ((IBigIntegerListnumericListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA), typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models1 = new List<BigIntegernumericListD12MIWA>();
                var models2 = new List<BigIntegernumericListD12MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD12MIWA>();
                var models2 = new List<BigIntegernumericListD12MIWA>();
                ((IBigIntegerListnumericListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericlistd12mi
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
                    BigIntegernumericListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericlistd12mi
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
                    BigIntegernumericListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA), typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models1 = new List<BigIntegernumericListD12MIWA>();
                var models2 = new List<BigIntegernumericListD12MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD12MIWA>();
                var models2 = new List<BigIntegernumericListD12MIWA>();
                ((IBigIntegerListnumericListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericlistd12mi
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
                    BigIntegernumericListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericlistd12mi
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
                    BigIntegernumericListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MI), typeof(BigIntegernumericListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models1 = new List<BigIntegernumericListD12MI>();
                var models2 = new List<BigIntegernumericListD12MI>();
                await ((IBigIntegerListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD12MI>();
                var models2 = new List<BigIntegernumericListD12MI>();
                ((IBigIntegerListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA), typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models1 = new List<BigIntegernumericListD12MIWA>();
                var models2 = new List<BigIntegernumericListD12MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD12MIWA>();
                var models2 = new List<BigIntegernumericListD12MIWA>();
                ((IBigIntegerListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models = await ((IBigIntegerListnumericListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

