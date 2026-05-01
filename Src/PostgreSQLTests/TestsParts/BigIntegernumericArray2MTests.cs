

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
    internal partial interface IBigIntegerListnumericArray
    {
    }
    
    internal partial class BigIntegerListnumericArray : IBigIntegerListnumericArray
    {


#region TestData

        private readonly BigIntegernumericArray2M[] _testData = new BigIntegernumericArray2M[]
        {
            new BigIntegernumericArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1944447752672940574L),

new System.Numerics.BigInteger(8948177187211768569L),

new System.Numerics.BigInteger(7037007118297575701L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7962859275424986627L),

new System.Numerics.BigInteger(167169969500509112L),

new System.Numerics.BigInteger(7521715893951127948L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1910310497867164924L),

new System.Numerics.BigInteger(6102036926322844631L),

new System.Numerics.BigInteger(5710129291301373187L),

new System.Numerics.BigInteger(1838595459695319260L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2873281881825693674L),

new System.Numerics.BigInteger(1426193927036306148L),

new System.Numerics.BigInteger(1350840461581976401L),

new System.Numerics.BigInteger(2924986882332038637L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5829896720776590230L),

new System.Numerics.BigInteger(5820184758896585053L),

new System.Numerics.BigInteger(3485950588598684862L),

},
},
            new BigIntegernumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1148192071890948066L),

new System.Numerics.BigInteger(4540821515815126155L),

new System.Numerics.BigInteger(5525345414714993838L),

new System.Numerics.BigInteger(1166605531494483953L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7176127780588694159L),

new System.Numerics.BigInteger(3035138968527222897L),

new System.Numerics.BigInteger(2186153749430828669L),

},
},
            new BigIntegernumericArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5995356800707883739L),

new System.Numerics.BigInteger(5924955268331988880L),

new System.Numerics.BigInteger(4845510870727348221L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3140856583187728464L),

new System.Numerics.BigInteger(2123131238794513323L),

new System.Numerics.BigInteger(2373022167815434598L),

new System.Numerics.BigInteger(1967083883501473946L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5004754597692209503L),

new System.Numerics.BigInteger(7093138752189513960L),

new System.Numerics.BigInteger(7577791304936272456L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4353460113830438354L),

new System.Numerics.BigInteger(1606602185567649937L),

new System.Numerics.BigInteger(4351480658828181004L),

new System.Numerics.BigInteger(2752520818751484787L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5121812906805582758L),

new System.Numerics.BigInteger(7361132709054800296L),

new System.Numerics.BigInteger(5113214803014850703L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1158085018975927768L),

new System.Numerics.BigInteger(1074211979730648308L),

new System.Numerics.BigInteger(8448716499719503275L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3326686894362875093L),

new System.Numerics.BigInteger(1018862704457750020L),

new System.Numerics.BigInteger(992883156691614000L),

new System.Numerics.BigInteger(4658944380910399916L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8722847878756460556L),

new System.Numerics.BigInteger(2352055631328153084L),

new System.Numerics.BigInteger(2081126683731467113L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6449126132419240469L),

new System.Numerics.BigInteger(1282630557393672176L),

new System.Numerics.BigInteger(3516067013651115927L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(996629824244498149L),

new System.Numerics.BigInteger(7402454321061880860L),

new System.Numerics.BigInteger(7270431328891500615L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6393033479953284720L),

new System.Numerics.BigInteger(5419517880828171371L),

new System.Numerics.BigInteger(6847718281590105600L),

new System.Numerics.BigInteger(8730272848139603719L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1071247186128824707L),

new System.Numerics.BigInteger(3705357919449711102L),

new System.Numerics.BigInteger(7310239904137035698L),

new System.Numerics.BigInteger(20507432825059876L),

},
},
            new BigIntegernumericArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8180737203642682523L),

new System.Numerics.BigInteger(1470684543315333189L),

new System.Numerics.BigInteger(8728707366399166072L),

new System.Numerics.BigInteger(6630360775598147789L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3952311619980879334L),

new System.Numerics.BigInteger(680579711840099831L),

new System.Numerics.BigInteger(2486185370956694201L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6118068693886930527L),

new System.Numerics.BigInteger(8677776467604241947L),

new System.Numerics.BigInteger(2103287706595442812L),

new System.Numerics.BigInteger(7400038758100722646L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5542974747645312812L),

new System.Numerics.BigInteger(4195760671528847015L),

new System.Numerics.BigInteger(1264745289905088553L),

new System.Numerics.BigInteger(5519368464947312165L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3974827511884881680L),

new System.Numerics.BigInteger(1402719649675633018L),

new System.Numerics.BigInteger(81053411672607372L),

new System.Numerics.BigInteger(4718720278820109579L),

},
},
            new BigIntegernumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5034617130822260967L),

new System.Numerics.BigInteger(5643446109606967212L),

new System.Numerics.BigInteger(4212891394789085909L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7722015549477428839L),

new System.Numerics.BigInteger(4198056494893784346L),

new System.Numerics.BigInteger(2324784680423832714L),

new System.Numerics.BigInteger(8870604169372630771L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6893842375081190099L),

new System.Numerics.BigInteger(4037090483528219507L),

new System.Numerics.BigInteger(185109925271946514L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1515326403892329095L),

new System.Numerics.BigInteger(4279451413395279807L),

new System.Numerics.BigInteger(4260622118755639916L),

},
},
            new BigIntegernumericArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1756906794794802022L),

new System.Numerics.BigInteger(3176457712455062679L),

new System.Numerics.BigInteger(6888620468961014144L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2631663519198789144L),

new System.Numerics.BigInteger(7262883891423584454L),

new System.Numerics.BigInteger(8165489037653799749L),

new System.Numerics.BigInteger(7745904657775997421L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2850741852558756694L),

new System.Numerics.BigInteger(381875053298226436L),

new System.Numerics.BigInteger(2111180950120918903L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6365858214859577604L),

new System.Numerics.BigInteger(8182248175448302282L),

new System.Numerics.BigInteger(3433190562021898083L),

},
},
            new BigIntegernumericArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6392270180046204032L),

new System.Numerics.BigInteger(4400587803279805582L),

new System.Numerics.BigInteger(2193993408074885484L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6326675063281250763L),

new System.Numerics.BigInteger(6738886545378427561L),

new System.Numerics.BigInteger(8555217356651614135L),

new System.Numerics.BigInteger(7627398505172219407L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2357688155163005423L),

new System.Numerics.BigInteger(8371251912542435203L),

new System.Numerics.BigInteger(8859842919767420687L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8796020906903517347L),

new System.Numerics.BigInteger(1691131827819796072L),

new System.Numerics.BigInteger(100581375451715193L),

new System.Numerics.BigInteger(414571089032004939L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1360685667933991311L),

new System.Numerics.BigInteger(6629689693964269912L),

new System.Numerics.BigInteger(4456873159041388750L),

new System.Numerics.BigInteger(5134048838313053127L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(282838202282979895L),

new System.Numerics.BigInteger(5777202069472077274L),

new System.Numerics.BigInteger(5049202955715190506L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5802743325014973679L),

new System.Numerics.BigInteger(4669266508541453916L),

new System.Numerics.BigInteger(2730920468228623223L),

},
},
            new BigIntegernumericArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8120552687978210667L),

new System.Numerics.BigInteger(181332991387801582L),

new System.Numerics.BigInteger(5386189964993846311L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8126420146160271467L),

new System.Numerics.BigInteger(7357710900101764144L),

new System.Numerics.BigInteger(8440375141697850270L),

},
},
            new BigIntegernumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3147039418789256637L),

new System.Numerics.BigInteger(212230894732157876L),

new System.Numerics.BigInteger(4760367255566333137L),

new System.Numerics.BigInteger(6582907560431766952L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3184723326113116727L),

new System.Numerics.BigInteger(526622100223863361L),

new System.Numerics.BigInteger(1516182342905281148L),

new System.Numerics.BigInteger(9120654784846024310L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3426066611020729814L),

new System.Numerics.BigInteger(2748960600965488202L),

new System.Numerics.BigInteger(2609555589321683016L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2156579930467239618L),

new System.Numerics.BigInteger(5739654282626850230L),

new System.Numerics.BigInteger(1188736471384328901L),

},
},
            new BigIntegernumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(124925319721669517L),

new System.Numerics.BigInteger(6292592661342099011L),

new System.Numerics.BigInteger(6780333931392715061L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7337692847719731984L),

new System.Numerics.BigInteger(2039211160967468565L),

new System.Numerics.BigInteger(4426119940337748287L),

new System.Numerics.BigInteger(148321830113982356L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6460929802730779800L),

new System.Numerics.BigInteger(3659604843255812113L),

new System.Numerics.BigInteger(8364522920054325352L),

new System.Numerics.BigInteger(9035914518979274640L),

},
},
            new BigIntegernumericArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9030536052781105365L),

new System.Numerics.BigInteger(4208307336667226519L),

new System.Numerics.BigInteger(3380567314621609165L),

new System.Numerics.BigInteger(2168605491981271024L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5112424284881357644L),

new System.Numerics.BigInteger(2565591302908603819L),

new System.Numerics.BigInteger(1255222459990933749L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5675596858594156355L),

new System.Numerics.BigInteger(5801896768075154496L),

new System.Numerics.BigInteger(1357096164021383550L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4939689046309032360L),

new System.Numerics.BigInteger(3693931396557328982L),

new System.Numerics.BigInteger(5412145302921948564L),

new System.Numerics.BigInteger(7610792947090493946L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(168543125423136613L),

new System.Numerics.BigInteger(1695334172477075279L),

new System.Numerics.BigInteger(5671867452374618371L),

},
},
            new BigIntegernumericArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7991503530895665670L),

new System.Numerics.BigInteger(8357784568865559625L),

new System.Numerics.BigInteger(1171567764496914452L),

new System.Numerics.BigInteger(3282591311839082L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3673753509275331877L),

new System.Numerics.BigInteger(6557964737479966207L),

new System.Numerics.BigInteger(5856977032652653843L),

new System.Numerics.BigInteger(7481941444646259795L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(197844847526866899L),

new System.Numerics.BigInteger(206580976745871749L),

new System.Numerics.BigInteger(6740144293713171351L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6668069751356616033L),

new System.Numerics.BigInteger(2916628734971570158L),

new System.Numerics.BigInteger(8095449340033175971L),

},
},
            new BigIntegernumericArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5340446446393850646L),

new System.Numerics.BigInteger(3107342019027463470L),

new System.Numerics.BigInteger(4505291519908403961L),

new System.Numerics.BigInteger(5859961319839476462L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8517526058166260022L),

new System.Numerics.BigInteger(321029684808050256L),

new System.Numerics.BigInteger(3380215918445840563L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8829523184412915292L),

new System.Numerics.BigInteger(8969008647144997855L),

new System.Numerics.BigInteger(494395140706538547L),

new System.Numerics.BigInteger(3880644088883331761L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9201579084088076411L),

new System.Numerics.BigInteger(5226133407393150986L),

new System.Numerics.BigInteger(6212272013720617403L),

new System.Numerics.BigInteger(9163768496988768268L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7153280560303756918L),

new System.Numerics.BigInteger(2018576064244449312L),

new System.Numerics.BigInteger(151629468661237247L),

new System.Numerics.BigInteger(3872971254543379788L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1881227995443933889L),

new System.Numerics.BigInteger(6298706330207725149L),

new System.Numerics.BigInteger(6715065187178269856L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3700760991811031499L),

new System.Numerics.BigInteger(4397581923411746419L),

new System.Numerics.BigInteger(956669601145659440L),

new System.Numerics.BigInteger(3116175996260394602L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2464472780006255678L),

new System.Numerics.BigInteger(8472080272505090968L),

new System.Numerics.BigInteger(273981335583080338L),

new System.Numerics.BigInteger(2872031800586603354L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(227127093802494666L),

new System.Numerics.BigInteger(5573334258016584739L),

new System.Numerics.BigInteger(4384495990404390280L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3667924716986351359L),

new System.Numerics.BigInteger(3920581087000453163L),

new System.Numerics.BigInteger(5998651209379443977L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2205351507367854173L),

new System.Numerics.BigInteger(6714929838908882745L),

new System.Numerics.BigInteger(6812855109085712316L),

new System.Numerics.BigInteger(6892746329657823131L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2182907679372454709L),

new System.Numerics.BigInteger(680308182768344003L),

new System.Numerics.BigInteger(8566469909867512942L),

},
},
            new BigIntegernumericArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4663563279859076442L),

new System.Numerics.BigInteger(3443625986427079486L),

new System.Numerics.BigInteger(8139588652787290709L),

new System.Numerics.BigInteger(1309467342955860589L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7019841378330368586L),

new System.Numerics.BigInteger(2426146422177336957L),

new System.Numerics.BigInteger(4217166617686303169L),

new System.Numerics.BigInteger(7117601426258096210L),

},
},
            new BigIntegernumericArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8161355057024068371L),

new System.Numerics.BigInteger(7920693417011803574L),

new System.Numerics.BigInteger(7684869562697901705L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6072290219498252577L),

new System.Numerics.BigInteger(1425986031976151534L),

new System.Numerics.BigInteger(5139437617385832103L),

new System.Numerics.BigInteger(1223896498716348335L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1122169839745192461L),

new System.Numerics.BigInteger(7736632678281382774L),

new System.Numerics.BigInteger(3561969099802588791L),

new System.Numerics.BigInteger(1444588632033848361L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1522464382756782208L),

new System.Numerics.BigInteger(349867254899392725L),

new System.Numerics.BigInteger(836874297655449614L),

new System.Numerics.BigInteger(142765040275419581L),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
INSERT INTO public.bigintegernumericarray2mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericArray)), 
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
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                List<BigIntegernumericArray2M> models = null;

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray2M> models = null;

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 102;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 66, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 97, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 24, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 17, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 45, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 44, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 44, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[23],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MIWA),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MI),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray2M),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
FROM public.binary_bigintegernumericarray2m m
LEFT JOIN public.binary_bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models =  ((IBigIntegerListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models = await ((IBigIntegerListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI), typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models1 = new List<BigIntegernumericArray2MI>();
                var models2 = new List<BigIntegernumericArray2MI>();
                await ((IBigIntegerListnumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MI>();
                var models2 = new List<BigIntegernumericArray2MI>();
                ((IBigIntegerListnumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models = await ((IBigIntegerListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

