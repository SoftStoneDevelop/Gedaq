

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1372635185105778798L),

new System.Numerics.BigInteger(6710763292272855889L),

new System.Numerics.BigInteger(8365837378525093577L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8765286469314236033L),

new System.Numerics.BigInteger(7626514838910126149L),

new System.Numerics.BigInteger(6976050615576151976L),

new System.Numerics.BigInteger(7001039201151274345L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5672955375156165727L),

new System.Numerics.BigInteger(3603602624667915160L),

new System.Numerics.BigInteger(990039662710777242L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5172253909520935153L),

new System.Numerics.BigInteger(6695688480931776267L),

new System.Numerics.BigInteger(2641866879747816773L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7378748071106364506L),

new System.Numerics.BigInteger(636565933600853269L),

new System.Numerics.BigInteger(8895826509999394489L),

new System.Numerics.BigInteger(2944738410621182942L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5652261167468722691L),

new System.Numerics.BigInteger(7806130150343823190L),

new System.Numerics.BigInteger(3723765223415134387L),

new System.Numerics.BigInteger(3277951963358017387L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5848143636725061878L),

new System.Numerics.BigInteger(2053453829673653953L),

new System.Numerics.BigInteger(2861087082193059738L),

new System.Numerics.BigInteger(6109623411763062510L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8367663740499684561L),

new System.Numerics.BigInteger(7503724441945036061L),

new System.Numerics.BigInteger(567952930608846250L),

new System.Numerics.BigInteger(2973147922901532666L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2643985667784194757L),

new System.Numerics.BigInteger(4343164380008213613L),

new System.Numerics.BigInteger(562254269729578040L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8645247040058573081L),

new System.Numerics.BigInteger(6768634694326050781L),

new System.Numerics.BigInteger(4810180838922623391L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(362811100405634517L),

new System.Numerics.BigInteger(4558224666305525654L),

new System.Numerics.BigInteger(5120080902807646473L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9119982553401160158L),

new System.Numerics.BigInteger(5647558065914505312L),

new System.Numerics.BigInteger(1584479729007513761L),

new System.Numerics.BigInteger(866721760104582511L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3403197039435745153L),

new System.Numerics.BigInteger(2323142715851888589L),

new System.Numerics.BigInteger(5461043172054525280L),

new System.Numerics.BigInteger(8260327513435608211L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4087349943791159216L),

new System.Numerics.BigInteger(8983157942108373478L),

new System.Numerics.BigInteger(671184494209738478L),

new System.Numerics.BigInteger(712136246603904139L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3468356790627336650L),

new System.Numerics.BigInteger(4354469560958049708L),

new System.Numerics.BigInteger(7573023553365329457L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1863399844819201186L),

new System.Numerics.BigInteger(6268581203111978629L),

new System.Numerics.BigInteger(2529678923867200001L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1871068703847319314L),

new System.Numerics.BigInteger(8094659435859975081L),

new System.Numerics.BigInteger(4771379286091239309L),

new System.Numerics.BigInteger(8582498301191820269L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(294922758620495938L),

new System.Numerics.BigInteger(8304285865072837915L),

new System.Numerics.BigInteger(1794422388823785235L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6546884341195967629L),

new System.Numerics.BigInteger(5756752794705870058L),

new System.Numerics.BigInteger(1469705984879714160L),

new System.Numerics.BigInteger(8060887369474396167L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8775316972301161313L),

new System.Numerics.BigInteger(9070716619652834436L),

new System.Numerics.BigInteger(5402019411912356606L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7513082058742235913L),

new System.Numerics.BigInteger(1495211986195473092L),

new System.Numerics.BigInteger(7510394179373798020L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7057577494059716363L),

new System.Numerics.BigInteger(7297535265966840172L),

new System.Numerics.BigInteger(7287608044212733655L),

new System.Numerics.BigInteger(4410503391826949183L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3976379701068555413L),

new System.Numerics.BigInteger(6439033627210938545L),

new System.Numerics.BigInteger(8222721849368216557L),

new System.Numerics.BigInteger(6398077389353867693L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(347576400256323074L),

new System.Numerics.BigInteger(2237456845798482370L),

new System.Numerics.BigInteger(458428381066171289L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6147926579683776654L),

new System.Numerics.BigInteger(6374308761734745569L),

new System.Numerics.BigInteger(8202938888178811382L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3510230020850926221L),

new System.Numerics.BigInteger(2738279330221089579L),

new System.Numerics.BigInteger(4401205137170124131L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(552167428028419261L),

new System.Numerics.BigInteger(6723406078935576244L),

new System.Numerics.BigInteger(6495609695825695681L),

new System.Numerics.BigInteger(3113498941936169200L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8833728468507596598L),

new System.Numerics.BigInteger(3397008263809711464L),

new System.Numerics.BigInteger(7478000035699047357L),

new System.Numerics.BigInteger(1617454183995077120L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6318311225970654684L),

new System.Numerics.BigInteger(6820776690580279707L),

new System.Numerics.BigInteger(2003518029949538417L),

new System.Numerics.BigInteger(7145016132499188174L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5677113717391685291L),

new System.Numerics.BigInteger(4705386981328201327L),

new System.Numerics.BigInteger(380820497308378176L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5949223156992002885L),

new System.Numerics.BigInteger(1957999570406149305L),

new System.Numerics.BigInteger(5727050567001537248L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7282139749574806985L),

new System.Numerics.BigInteger(7215475849048905102L),

new System.Numerics.BigInteger(8722752623431402009L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6326235694128016996L),

new System.Numerics.BigInteger(9174212605029679026L),

new System.Numerics.BigInteger(7805891347423768817L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2256910941967599798L),

new System.Numerics.BigInteger(3104007762844596605L),

new System.Numerics.BigInteger(4038637305948044172L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1748136198739247817L),

new System.Numerics.BigInteger(1603185802058182710L),

new System.Numerics.BigInteger(4211040681204168873L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5327405521346625866L),

new System.Numerics.BigInteger(8771166174900302520L),

new System.Numerics.BigInteger(3380581317398916977L),

new System.Numerics.BigInteger(652761390448654064L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3587017321556111249L),

new System.Numerics.BigInteger(9107996758854316524L),

new System.Numerics.BigInteger(301022510773488090L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6133896556123404100L),

new System.Numerics.BigInteger(1024715179397122209L),

new System.Numerics.BigInteger(5925582837904425828L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6513813556527884752L),

new System.Numerics.BigInteger(2892018318638478203L),

new System.Numerics.BigInteger(2447779458621821577L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4909055067638921931L),

new System.Numerics.BigInteger(3177880044128693418L),

new System.Numerics.BigInteger(202096990639066404L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8283731123410158041L),

new System.Numerics.BigInteger(1073351449613412084L),

new System.Numerics.BigInteger(6926392239824865406L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6551760310712596875L),

new System.Numerics.BigInteger(1187687794692770260L),

new System.Numerics.BigInteger(5715362784995748269L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8728471052998345135L),

new System.Numerics.BigInteger(7050584336782395270L),

new System.Numerics.BigInteger(9105291040197438107L),

new System.Numerics.BigInteger(6053680191433370762L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7482881652083427205L),

new System.Numerics.BigInteger(848382906109145615L),

new System.Numerics.BigInteger(1785189306002749171L),

new System.Numerics.BigInteger(7037406725761152855L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2065406513916293162L),

new System.Numerics.BigInteger(9035326679583121715L),

new System.Numerics.BigInteger(9044724382439951863L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2677166946409671145L),

new System.Numerics.BigInteger(6472032454606111785L),

new System.Numerics.BigInteger(5919131961505238933L),

new System.Numerics.BigInteger(139270791576953100L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6618564246465096060L),

new System.Numerics.BigInteger(6593868236010458758L),

new System.Numerics.BigInteger(6654366902546606299L),

new System.Numerics.BigInteger(3475039519641277282L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3566068535065949376L),

new System.Numerics.BigInteger(7032958460116286276L),

new System.Numerics.BigInteger(2397611291761474330L),

new System.Numerics.BigInteger(5878789653605909107L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2457759274013403972L),

new System.Numerics.BigInteger(6178762315546651982L),

new System.Numerics.BigInteger(7456056352066933598L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(734171030081468752L),

new System.Numerics.BigInteger(4836286141067801652L),

new System.Numerics.BigInteger(1902134719203159379L),

new System.Numerics.BigInteger(96311006826000629L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3756102165257780360L),

new System.Numerics.BigInteger(8510167215737646454L),

new System.Numerics.BigInteger(8558858013537901818L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7798333368966865931L),

new System.Numerics.BigInteger(3218048928704024597L),

new System.Numerics.BigInteger(263005400492240456L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8854262283197530976L),

new System.Numerics.BigInteger(6696638005319418710L),

new System.Numerics.BigInteger(7146775936261489006L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1336581281279894991L),

new System.Numerics.BigInteger(7118959139639426388L),

new System.Numerics.BigInteger(3144637762090596262L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3855750220940887336L),

new System.Numerics.BigInteger(2564109265666424266L),

new System.Numerics.BigInteger(2589839440031612997L),

new System.Numerics.BigInteger(2733338949267800010L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5472395835858504680L),

new System.Numerics.BigInteger(2454520783857565997L),

new System.Numerics.BigInteger(6745304293617876604L),

new System.Numerics.BigInteger(6208587124029908526L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7550867462876852489L),

new System.Numerics.BigInteger(2704045739276899928L),

new System.Numerics.BigInteger(9183449680583569071L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3205204191681580320L),

new System.Numerics.BigInteger(2927609371892229283L),

new System.Numerics.BigInteger(6282625616339906669L),

new System.Numerics.BigInteger(8223725947599299812L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3326682035709143620L),

new System.Numerics.BigInteger(8304140536519540816L),

new System.Numerics.BigInteger(3326307834535980672L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6376631386987946518L),

new System.Numerics.BigInteger(2941528296355627678L),

new System.Numerics.BigInteger(2075460510070348923L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(244603152453705184L),

new System.Numerics.BigInteger(4617452935487194631L),

new System.Numerics.BigInteger(4194979944797609116L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1589762714764198488L),

new System.Numerics.BigInteger(3133444417341658455L),

new System.Numerics.BigInteger(826151931223047590L),

new System.Numerics.BigInteger(1323407892132375734L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1075210181861915126L),

new System.Numerics.BigInteger(1705590422161618793L),

new System.Numerics.BigInteger(2131728450519653664L),

new System.Numerics.BigInteger(1093592412728147940L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139208767808297861L),

new System.Numerics.BigInteger(4634732227779422274L),

new System.Numerics.BigInteger(5199881096871952575L),

new System.Numerics.BigInteger(4589178032978435564L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8128404365843629956L),

new System.Numerics.BigInteger(2726044699592618081L),

new System.Numerics.BigInteger(7312839448464580564L),

new System.Numerics.BigInteger(3354863554216329527L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5362280606252378503L),

new System.Numerics.BigInteger(9162276594803068523L),

new System.Numerics.BigInteger(5600005207661265073L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1706077460880470207L),

new System.Numerics.BigInteger(697257707044472665L),

new System.Numerics.BigInteger(116805791358746004L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6030748465590087508L),

new System.Numerics.BigInteger(246085381974873138L),

new System.Numerics.BigInteger(730184394851049145L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(409673216024591208L),

new System.Numerics.BigInteger(6889775512973099282L),

new System.Numerics.BigInteger(7060700842670443439L),

new System.Numerics.BigInteger(4016428757403179638L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4850933998234898420L),

new System.Numerics.BigInteger(1535923971216715353L),

new System.Numerics.BigInteger(6219227255381663630L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5096732578321496790L),

new System.Numerics.BigInteger(208517697370930199L),

new System.Numerics.BigInteger(4111613634873219930L),

new System.Numerics.BigInteger(8233131080465500203L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4947027742260675495L),

new System.Numerics.BigInteger(1016047666595339633L),

new System.Numerics.BigInteger(3078774429477748405L),

new System.Numerics.BigInteger(2933326342118079326L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8521569518849442484L),

new System.Numerics.BigInteger(7014937944859958152L),

new System.Numerics.BigInteger(8791827378824973332L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4165546307630053717L),

new System.Numerics.BigInteger(7163283185876044707L),

new System.Numerics.BigInteger(2904889289817103506L),

new System.Numerics.BigInteger(2194821093995610897L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4863678879878896358L),

new System.Numerics.BigInteger(7360814824155153705L),

new System.Numerics.BigInteger(8414376567174372896L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7597555022813311078L),

new System.Numerics.BigInteger(2029638928165973613L),

new System.Numerics.BigInteger(4877589383939736212L),

new System.Numerics.BigInteger(6663892015779041523L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8641173809116462764L),

new System.Numerics.BigInteger(5008248444464281722L),

new System.Numerics.BigInteger(4631651138342436148L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1565906334447684881L),

new System.Numerics.BigInteger(8207193667179163466L),

new System.Numerics.BigInteger(8175792632774193506L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3684078266153372878L),

new System.Numerics.BigInteger(5902088506339194716L),

new System.Numerics.BigInteger(208308982258663297L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2361144100710554526L),

new System.Numerics.BigInteger(542174109580168708L),

new System.Numerics.BigInteger(1528698890568605687L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3405048784911007016L),

new System.Numerics.BigInteger(6811697230881105298L),

new System.Numerics.BigInteger(5027172907551521481L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(19057176528675883L),

new System.Numerics.BigInteger(6506962571864342694L),

new System.Numerics.BigInteger(1595149488097473645L),

new System.Numerics.BigInteger(4516697810281107242L),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2mi(
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
INSERT INTO public.bigintegernumericlistd1e2mi(
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
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
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
    bigintegernumericlistd1e2mi_id
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
                methodParametrName: "bigintegernumericlistd1e2mi_id", 
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
    bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
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
    bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
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
                methodParametrName: "bigintegernumericlistd1e2mi_id", 
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
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
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
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 111;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 57;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 91, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 23, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[34], false);
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
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 28, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[34], false);
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
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 118, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 135, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[34], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 20, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[34], false);
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
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models =  ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
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
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
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
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
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
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MI),
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
                var importCollection = new List<BigIntegernumericListD1E2MI>(2);
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
                    BigIntegernumericListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MI>(2);
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
                    BigIntegernumericListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
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
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
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
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
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
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
bigintegernumericlistd1e2mi_id,
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
LEFT JOIN public.binary_bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
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
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
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
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
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
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI), typeof(BigIntegernumericListD1E2MI)],
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
                var models1 = new List<BigIntegernumericListD1E2MI>();
                var models2 = new List<BigIntegernumericListD1E2MI>();
                await ((IBigIntegerListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MI>();
                var models2 = new List<BigIntegernumericListD1E2MI>();
                ((IBigIntegerListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
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
                    BigIntegernumericListD1E2MI.AssertModel(model, expectedModel, false);
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
                    BigIntegernumericListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

