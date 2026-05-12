

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
    Id = 2,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5592195268581749555L),
new System.Numerics.BigInteger(6497817913348681299L),
new System.Numerics.BigInteger(2340788205678098746L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 3,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1134831001713864924L),
new System.Numerics.BigInteger(8804289471457268972L),
new System.Numerics.BigInteger(8307571008090530942L),
new System.Numerics.BigInteger(553018437669355460L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2548967361631950348L),
new System.Numerics.BigInteger(6392061322529815462L),
new System.Numerics.BigInteger(7454348570462176167L),
new System.Numerics.BigInteger(544892494327062629L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6879755268464383575L),
new System.Numerics.BigInteger(6410596394226571390L),
new System.Numerics.BigInteger(3151253065223577039L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5976729351953406079L),
new System.Numerics.BigInteger(4565498423600327274L),
new System.Numerics.BigInteger(8898770106388801460L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8684921494218967511L),
new System.Numerics.BigInteger(7587815022825325167L),
new System.Numerics.BigInteger(7316994650564895149L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6312648133444011602L),
new System.Numerics.BigInteger(7738984236933570279L),
new System.Numerics.BigInteger(5977827328772475254L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6805179179506759266L),
new System.Numerics.BigInteger(2491921746257703818L),
new System.Numerics.BigInteger(9016031408812021391L),
new System.Numerics.BigInteger(3954727159827445120L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2054654961591161251L),
new System.Numerics.BigInteger(3364952660529620377L),
new System.Numerics.BigInteger(9221296423174929261L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2088420079188825117L),
new System.Numerics.BigInteger(1372210418626644666L),
new System.Numerics.BigInteger(3466056057405877296L),
new System.Numerics.BigInteger(2476585062557977444L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3160219919565546174L),
new System.Numerics.BigInteger(6639509183183018243L),
new System.Numerics.BigInteger(7608577574030711829L),
new System.Numerics.BigInteger(1867560424687285158L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8338052992430314678L),
new System.Numerics.BigInteger(4170573071447869370L),
new System.Numerics.BigInteger(4352575520835667088L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2535536789559228122L),
new System.Numerics.BigInteger(8948898021575749985L),
new System.Numerics.BigInteger(7463147703525164061L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1948254400802197793L),
new System.Numerics.BigInteger(1214609424765629219L),
new System.Numerics.BigInteger(1321373965091139879L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4391405665115528591L),
new System.Numerics.BigInteger(5574515317441683560L),
new System.Numerics.BigInteger(5668732960139909259L),
new System.Numerics.BigInteger(489251528686059362L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2890204774034577315L),
new System.Numerics.BigInteger(9066126174897703737L),
new System.Numerics.BigInteger(1559166067040999192L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8970976637099859002L),
new System.Numerics.BigInteger(6987370476453241953L),
new System.Numerics.BigInteger(6040437361533011957L),
new System.Numerics.BigInteger(4315499418531812766L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5178742897600974191L),
new System.Numerics.BigInteger(3392489387725456445L),
new System.Numerics.BigInteger(6502409233498069288L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9053404634578086141L),
new System.Numerics.BigInteger(1484630015255263L),
new System.Numerics.BigInteger(4583802432172428267L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6666074496098728362L),
new System.Numerics.BigInteger(3357145754870126744L),
new System.Numerics.BigInteger(2274270952152810336L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7432862390777153756L),
new System.Numerics.BigInteger(1816359845768581350L),
new System.Numerics.BigInteger(2579935622533519274L),
new System.Numerics.BigInteger(3358357877151280727L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1959151751028412788L),
new System.Numerics.BigInteger(7403941836782991423L),
new System.Numerics.BigInteger(3158229357262452010L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(318228180716373475L),
new System.Numerics.BigInteger(8993009535454019851L),
new System.Numerics.BigInteger(6042732814179547545L),
new System.Numerics.BigInteger(3016990768197316181L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(373310411020724025L),
new System.Numerics.BigInteger(409134061573193948L),
new System.Numerics.BigInteger(8044531959331376405L),
new System.Numerics.BigInteger(3944585284218508554L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4383943006875015718L),
new System.Numerics.BigInteger(8834689220878666260L),
new System.Numerics.BigInteger(27259712628879388L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5485604665425816172L),
new System.Numerics.BigInteger(3210650723381903947L),
new System.Numerics.BigInteger(4539637121668379034L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5793620944678894210L),
new System.Numerics.BigInteger(7898498556496610754L),
new System.Numerics.BigInteger(4613486510782214726L),
new System.Numerics.BigInteger(1469215151097906346L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4667064690545731854L),
new System.Numerics.BigInteger(2384264494176206882L),
new System.Numerics.BigInteger(729658784138429595L),
new System.Numerics.BigInteger(6026454575379042607L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5494204197657754659L),
new System.Numerics.BigInteger(7342298922928256809L),
new System.Numerics.BigInteger(4592566706513308510L),
new System.Numerics.BigInteger(2519279443438178050L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1323609998503653919L),
new System.Numerics.BigInteger(6240847104084697785L),
new System.Numerics.BigInteger(6580413839494156316L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(546284352970658501L),
new System.Numerics.BigInteger(6313853661892296889L),
new System.Numerics.BigInteger(5191569764281083627L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4546171144314261330L),
new System.Numerics.BigInteger(3263117202124715776L),
new System.Numerics.BigInteger(3975811910534032988L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(669388792722191413L),
new System.Numerics.BigInteger(115907052659418288L),
new System.Numerics.BigInteger(9220449228168834400L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(148080983653351075L),
new System.Numerics.BigInteger(6888043376852379549L),
new System.Numerics.BigInteger(1495417881953580165L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1010538540123127365L),
new System.Numerics.BigInteger(8120917391511577978L),
new System.Numerics.BigInteger(4407103320213590528L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1986873061258079929L),
new System.Numerics.BigInteger(942703066061658061L),
new System.Numerics.BigInteger(4776731859435104067L),
new System.Numerics.BigInteger(1804477040415711556L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2278830944405347863L),
new System.Numerics.BigInteger(127113220743294633L),
new System.Numerics.BigInteger(7890266933945432628L),
new System.Numerics.BigInteger(9013845921209712014L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7198895475154454009L),
new System.Numerics.BigInteger(6798615356727919808L),
new System.Numerics.BigInteger(58224127581449057L),
new System.Numerics.BigInteger(7730233980010170171L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2428557160094540143L),
new System.Numerics.BigInteger(2464443855046161764L),
new System.Numerics.BigInteger(1179133852815182577L),
new System.Numerics.BigInteger(6618811899261602426L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3791212957960102681L),
new System.Numerics.BigInteger(4371522601043146166L),
new System.Numerics.BigInteger(9119209236054011340L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(379349658080912258L),
new System.Numerics.BigInteger(9084733192633315084L),
new System.Numerics.BigInteger(5296461365656635380L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1965434535512160082L),
new System.Numerics.BigInteger(8458456838156128598L),
new System.Numerics.BigInteger(7899161344683647528L),
new System.Numerics.BigInteger(3701684019965383230L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5405321540583200012L),
new System.Numerics.BigInteger(675030639070522309L),
new System.Numerics.BigInteger(6630965916675377206L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1614672415447164522L),
new System.Numerics.BigInteger(6281300679825998167L),
new System.Numerics.BigInteger(6464825435556617478L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7482107115264047496L),
new System.Numerics.BigInteger(4083232356118966062L),
new System.Numerics.BigInteger(1989733552526667865L),
new System.Numerics.BigInteger(2600145171290399697L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9153079724593294134L),
new System.Numerics.BigInteger(1145125860136144624L),
new System.Numerics.BigInteger(3449272431321960814L),
new System.Numerics.BigInteger(8612638640785109140L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(55248675386040902L),
new System.Numerics.BigInteger(694118419001179407L),
new System.Numerics.BigInteger(4964295923020474236L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6975712486405227930L),
new System.Numerics.BigInteger(5145208460062659421L),
new System.Numerics.BigInteger(8457779123190637816L),
new System.Numerics.BigInteger(7579940448927042643L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6225224061985356950L),
new System.Numerics.BigInteger(8689390536880783172L),
new System.Numerics.BigInteger(122671165870477273L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4067432600468206191L),
new System.Numerics.BigInteger(5088282181205720854L),
new System.Numerics.BigInteger(7499010207396878086L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5309586675108591346L),
new System.Numerics.BigInteger(3837407850770506120L),
new System.Numerics.BigInteger(3836459345498329881L),
new System.Numerics.BigInteger(1745277536098495819L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5640910427010699324L),
new System.Numerics.BigInteger(4375555250161872150L),
new System.Numerics.BigInteger(3017188059870699595L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1835521694582714158L),
new System.Numerics.BigInteger(2445016815004544569L),
new System.Numerics.BigInteger(5259988924584990785L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2967134285467836841L),
new System.Numerics.BigInteger(1858772351821589677L),
new System.Numerics.BigInteger(8026792006379509964L),
new System.Numerics.BigInteger(1665094083728583432L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3579462472687486272L),
new System.Numerics.BigInteger(3973959119752356070L),
new System.Numerics.BigInteger(3062566368955741307L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 127,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3524444950752199565L),
new System.Numerics.BigInteger(4708086546022324603L),
new System.Numerics.BigInteger(2696078152215251392L),
new System.Numerics.BigInteger(5862113741290537141L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6731727438818063609L),
new System.Numerics.BigInteger(7663528211782783562L),
new System.Numerics.BigInteger(4719365094774247120L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7718594873754872999L),
new System.Numerics.BigInteger(3018478328801139371L),
new System.Numerics.BigInteger(6608879908981487576L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8885358431403784825L),
new System.Numerics.BigInteger(1180839584240692284L),
new System.Numerics.BigInteger(5284587760816356370L),
new System.Numerics.BigInteger(8244964553312587843L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5049778384760475318L),
new System.Numerics.BigInteger(438182173219352821L),
new System.Numerics.BigInteger(4716288892453442229L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 140,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1682282523169058156L),
new System.Numerics.BigInteger(4154882481431886677L),
new System.Numerics.BigInteger(646429282030923887L),
new System.Numerics.BigInteger(7561559043835208294L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(443528015294319453L),
new System.Numerics.BigInteger(1858929587269769682L),
new System.Numerics.BigInteger(4725086078996060735L),
new System.Numerics.BigInteger(1109974933866349417L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(925557094171270273L),
new System.Numerics.BigInteger(7688124517336803098L),
new System.Numerics.BigInteger(126651498349569719L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2445834157694077944L),
new System.Numerics.BigInteger(276582027207497142L),
new System.Numerics.BigInteger(4875047938826177476L),
new System.Numerics.BigInteger(7417578952576693244L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2738934539567560613L),
new System.Numerics.BigInteger(517391581606357543L),
new System.Numerics.BigInteger(5163653129631975844L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5928048632131152356L),
new System.Numerics.BigInteger(1362615634601524810L),
new System.Numerics.BigInteger(5475337352417353970L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(15566257995647552L),
new System.Numerics.BigInteger(2158801853723337392L),
new System.Numerics.BigInteger(3196274992338541913L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5250348887654923874L),
new System.Numerics.BigInteger(6531419008177432650L),
new System.Numerics.BigInteger(7174344905879360683L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6771066638634469505L),
new System.Numerics.BigInteger(4145218707224132861L),
new System.Numerics.BigInteger(5458391647015147094L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3798680023586098600L),
new System.Numerics.BigInteger(7177286317941169126L),
new System.Numerics.BigInteger(7751262584464333349L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3317048971872274168L),
new System.Numerics.BigInteger(6096113431694720879L),
new System.Numerics.BigInteger(3258924421749611473L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 174,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8709862359814975026L),
new System.Numerics.BigInteger(8991832785083215620L),
new System.Numerics.BigInteger(3778784761613560745L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7111760253188257044L),
new System.Numerics.BigInteger(3477114255119148295L),
new System.Numerics.BigInteger(1185750884123269265L),
new System.Numerics.BigInteger(9127456330265692603L),
},
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 83, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
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
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 75, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 75, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 12, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 157, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 42, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 107, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 149, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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

